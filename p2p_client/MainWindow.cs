using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using p2p_client;

namespace SparkleApp
{
    public partial class MainWindow : Form
    {
        //p2p
        private const int Port = 1723;
        private static readonly object Locker = new object();

        public static string Passtext;

        public static bool Allowshowdisplay;

        readonly NATUPNPLib.UPnPNATClass _upnpnat = new NATUPNPLib.UPnPNATClass();

        public MainWindow()
        {
            InitializeComponent();
            FileReceiverTextBox.AllowDrop = true;
            FileReceiverTextBox.DragEnter += FileReceiverTextBox_DragEnter;
            FileReceiverTextBox.DragDrop += FileReceiverTextBox_DragDrop;

            FileReceiverTextBox.Click += FileReceiverTextBox_Click;
        }

        private void ResetControls()
        {
            FileReceiverTextBox.Enabled = SendFileButton.Enabled = true;
            SendFileButton.Text = "Send";
            TransmitterProgressBar.Value = 0;
            //TransmitterProgressBar.Style = ProgressBarStyle.Continuous;

            ReceiverTextBox.Text = "Waiting...";
            ReceiverProgressBar.Value = 0;
            //progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void FileReceiverTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))

                e.Effect = DragDropEffects.Move;
        }

        private void FileReceiverTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                var objects = (string[]) e.Data.GetData(DataFormats.FileDrop);
                // В objects хранятся пути к папкам и файлам
                FileReceiverTextBox.Text = null;
                for (var i = 0; i < objects.Length; i++)
                    FileReceiverTextBox.Text += objects[i] /* + Environment.NewLine*/;
            }
        }

        private void FileReceiverTextBox_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileReceiverTextBox.Text = ofd.FileName/*SafeFileName*/;
            }
        }

        //p2p передача
        private async void SendFileButton_Click(object sender, EventArgs e)
        {
            FileReceiverTextBox.Enabled = SendFileButton.Enabled = false;
            //TransmitterProgressBar.Style = ProgressBarStyle.Marquee;

            // парс ІР і файла
            SendFileButton.Text = "Preparing...";
            IPAddress address;
            FileInfo file;
            FileStream fileStream;
            //int PORT = Int32.Parse(textBox2.Text);
            //if (textBox2.Text == null)
            //{
            //    MessageBox.Show("Error with PORT");
            //    resetControls();
            //    return;
            //}
            if (!IPAddress.TryParse(EnterIPTextBox.Text, out address))
            {
                MessageBox.Show("Error with IP Address");
                ResetControls();
                return;
            }
            try
            {
                file = new FileInfo(FileReceiverTextBox.Text);
                fileStream = file.OpenRead();
            }
            catch
            {
                MessageBox.Show("Error opening file");
                ResetControls();
                return;
            }

            // Connecting
            SendFileButton.Text = "Connecting...";
            var client = new TcpClient();
            try
            {
                await client.ConnectAsync(address, Port);

            }
            catch
            {
                MessageBox.Show("Error connecting to destination");
                ResetControls();
                return;
            }
            var ns = client.GetStream();

            // Send file info
            SendFileButton.Text = "Sending file info...";
            {
                var fileName = Encoding.ASCII.GetBytes(file.Name);
                var fileNameLength = BitConverter.GetBytes(fileName.Length);
                var fileLength = BitConverter.GetBytes(file.Length);
                await ns.WriteAsync(fileLength, 0, fileLength.Length);
                await ns.WriteAsync(fileNameLength, 0, fileNameLength.Length);
                await ns.WriteAsync(fileName, 0, fileName.Length);
            }

            // провєрка прав
            SendFileButton.Text = "Getting permission...";
            {
                var permission = new byte[1];
                await ns.ReadAsync(permission, 0, 1);
                if (permission[0] != 1)
                {
                    MessageBox.Show("Permission denied");
                    ResetControls();
                    return;
                }
            }

            // отправка
            SendFileButton.Text = "Sending...";
            //progressBar2.Style = ProgressBarStyle.Continuous;
            int read;
            var totalWritten = 0;
            var buffer = new byte[32*1024]; // 32k chunks
            while ((read = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await ns.WriteAsync(buffer, 0, read);
                totalWritten += read;
                TransmitterProgressBar.Value = (int) (100d*totalWritten/file.Length);
            }

            fileStream.Dispose();
            client.Close();
            MessageBox.Show("Sending complete!");
            ResetControls();
        }

        public static IPAddress GetLocalAdress()
        {
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface network in networkInterfaces)
            {

                IPInterfaceProperties properties = network.GetIPProperties();

                if (properties.GatewayAddresses.Count == 0)//вся магия вот в этой строке
                    continue;

                foreach (UnicastIPAddressInformation address in properties.UnicastAddresses)
                {

                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    return address.Address;
                }
            }
            return default(IPAddress);
        }

        //прійом
        protected override async void OnShown(EventArgs e)
        {
            try //your ip in YourIPTextBox
            {
                //ip
                IPAddress addrs = IPAddress.Parse(new WebClient().DownloadString("https://api.ipify.org/"));
                YourIPTextBox.Text = addrs.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка соеденения с https://api.ipify.org/ . Пожалуйста проверьте подключение к интернету");
                throw;
            }
            // Listen
            TcpListener listener = TcpListener.Create(Port);
            listener.Start();


            //var host = Dns.GetHostName();
            //IPAddress ip = Dns.GetHostEntry(host).AddressList[2];
            try
            {
                //IPAddress ipv4Address = Array.FindLast(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);
                //var ipv4Address = new IPEndPoint(GetLocalAdress(), 0);
                textBox1.Text = GetLocalAdress().ToString();
                // після відкриття порта пробрасую його через роутер
                NATUPNPLib.IStaticPortMappingCollection mappings = _upnpnat.StaticPortMappingCollection;
                mappings.Add(Port, "TCP", Port, GetLocalAdress().ToString(), true, "SparkleApp TCP Port");
            }
            catch (Exception z)
            {
                MessageBox.Show(z.ToString());
                return;
            }

            //ip array
            //IPAddress[] ipv4Addresses = Array.FindAll(
            //Dns.GetHostEntry(string.Empty).AddressList,
            //a => a.AddressFamily == AddressFamily.InterNetwork);
            //or use Array.Find or Array.FindLast if you just want one.


            ReceiverTextBox.Text = "Waiting...";
            TcpClient client = await listener.AcceptTcpClientAsync();
            NetworkStream ns = client.GetStream();

            // Get file info
            float fileLength;
            string fileName;
            {
                byte[] fileNameBytes;
                var fileNameLengthBytes = new byte[4]; //int32
                var fileLengthBytes = new byte[8]; //int64

                await ns.ReadAsync(fileLengthBytes, 0, 8); // int64
                await ns.ReadAsync(fileNameLengthBytes, 0, 4); // int32
                fileNameBytes = new byte[BitConverter.ToInt32(fileNameLengthBytes, 0)];
                await ns.ReadAsync(fileNameBytes, 0, fileNameBytes.Length);

                fileLength = BitConverter.ToInt64(fileLengthBytes, 0);
                fileName = Encoding.ASCII.GetString(fileNameBytes);
            }

            // Get permission
            if (MessageBox.Show($"Requesting permission to receive file:\r\n\r\n{fileName}\r\n{fileLength/1024/1024:N2} Megabytes long", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            // виставляєм куда засейвитьт файл (но пока воно тіки сохраня в папку рядом)
            var sfd = new SaveFileDialog
            {
                CreatePrompt = false,
                OverwritePrompt = true,
                FileName = fileName
            };
            //if (sfd.ShowDialog() != DialogResult.OK)
            //{
            //    ns.WriteByte(0); // Permission denied
            //    return;
            //}
            ns.WriteByte(1); // Permission grantedd
            FileStream fileStream = File.Open(sfd.FileName, FileMode.Create);

            // Receive
            ReceiverTextBox.Text = "Receiving...";
            //progressBar1.Style = ProgressBarStyle.Continuous;
            ReceiverProgressBar.Value = 0;
            int read;
            var totalRead = 0;
            var buffer = new byte[32*1024]; // 32k chunks
            while ((read = await ns.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await fileStream.WriteAsync(buffer, 0, read);
                totalRead += read;
                ReceiverProgressBar.Value = (int) (100d*totalRead/fileLength);
            }

            fileStream.Dispose();
            client.Close();
            MessageBox.Show("File successfully received");

            //рестарт після прийома файла (замінить!)
            if (!client.Connected)
            {
                ResetControls();
            }
        }

        //chat_open

        //public static void chat_open()
        //{
        //    const string AppMutexName = "chat";
        //    using (Mutex mutex = new Mutex(false, AppMutexName))
        //    {
        //        bool Running = !mutex.WaitOne(0, false);
        //        if (!Running)
        //        {
        //                lock (locker)
        //                Application.Run(new chat());
        //        }
        //        else
        //        {
        //            // App already launched.
        //            MessageBox.Show("chat is alredy launched!");
        //        }
        //    }
        //}

        public static void chat_open()
        {
            lock (Locker)
                Application.Run(new Chat());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Udpp2P();
            f.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private void debug_picture_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                textBox1.Visible = true;
                button1.Visible = true;
                flatLabel1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                button1.Visible = false;
                flatLabel1.Visible = false;
            }
        }
        private void chat_picture_Click(object sender, EventArgs e)
        {
            IPAddress address;
            if (!IPAddress.TryParse(EnterIPTextBox.Text, out address))
            {
                MessageBox.Show("Error with IP Address");
            }
            else
            {
                //запуск чата
                var t = new Thread(chat_open);
                t.Start();
            }
            //передача ІР в чат
            Passtext = EnterIPTextBox.Text;

            Allowshowdisplay = true;

            //for debug
            //chat f = new chat();
            //f.Show(); 
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            NATUPNPLib.IStaticPortMappingCollection mappings = _upnpnat.StaticPortMappingCollection;
            mappings.Remove(Port, "TCP");
            try
            {
                Chat.Upnpclose();
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
            Environment.Exit(0);
        }
    }
}