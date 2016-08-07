using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace p2p_client
{
    public partial class MainWindow : Form
    {
        //p2p
        private const int PORT = 1723;
        private static readonly object locker = new object();

        public MainWindow()
        {
            InitializeComponent();
            FileReceiverTextBox.AllowDrop = true;
            FileReceiverTextBox.DragEnter += FileReceiverTextBox_DragEnter;
            FileReceiverTextBox.DragDrop += FileReceiverTextBox_DragDrop;

            FileReceiverTextBox.Click += FileReceiverTextBox_Click;

            //ip
            var addrs = IPAddress.Parse(new WebClient().DownloadString("https://api.ipify.org/"));
            YourIPTextBox.Text = addrs.ToString();
        }

        private void resetControls()
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
                    FileReceiverTextBox.Text += objects[i];
            }
        }

        private void FileReceiverTextBox_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileReceiverTextBox.Text = ofd.FileName;
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
                resetControls();
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
                resetControls();
                return;
            }

            // Connecting
            SendFileButton.Text = "Connecting...";
            var client = new TcpClient();
            try
            {
                await client.ConnectAsync(address, PORT);
            }
            catch
            {
                MessageBox.Show("Error connecting to destination");
                resetControls();
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
                    resetControls();
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
            resetControls();
        }

        //прійом
        protected override async void OnShown(EventArgs e)
        {
            // Listen
            var listener = TcpListener.Create(PORT);
            listener.Start();
            ReceiverTextBox.Text = "Waiting...";
            var client = await listener.AcceptTcpClientAsync();
            var ns = client.GetStream();

            // Get file info
            long fileLength;
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
            if (
                MessageBox.Show(
                    string.Format("Requesting permission to receive file:\r\n\r\n{0}\r\n{1} bytes long", fileName,
                        fileLength), "", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            // виставляєм куда засейвитьт файл (но пока воно тіки сохраня в папку)
            var sfd = new SaveFileDialog();
            sfd.CreatePrompt = false;
            sfd.OverwritePrompt = true;
            sfd.FileName = fileName;
            //if (sfd.ShowDialog() != DialogResult.OK)
            //{
            //    ns.WriteByte(0); // Permission denied
            //    return;
            //}
            ns.WriteByte(1); // Permission grantedd
            var fileStream = File.Open(sfd.FileName, FileMode.Create);

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

            if (!client.Connected)
            {
                Application.Restart();
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
            lock (locker)
                Application.Run(new chat());
        }


        private void flatButton1_Click(object sender, EventArgs e)
        {
            //запуск чата
            var t = new Thread(chat_open);
            t.Start();
        }
    }
}