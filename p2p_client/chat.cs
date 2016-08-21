using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SparkleApp
{
    public partial class Chat : Form
    {
        private const int Charport = 54545/*54236*//*43585*/;
        //private readonly string userName = broadcastAddress;
        //private string _broadcastAddress = "127.0.0.1";
        public bool Allowshowdisplay = MainWindow.Allowshowdisplay;

        //private readonly MainWindow otherForm = new MainWindow();
        private UdpClient _receivingClient;
        private Thread _receivingThread;
        private UdpClient _udpClient;

        static NATUPNPLib.UPnPNATClass upnpnat = new NATUPNPLib.UPnPNATClass();

        public Chat()
        {
            InitializeComponent();
            //chat
            ChatSendButton.Click += ChatSendButton_Click;
            InitializeSender();
            InitializeReceiver();

            //enter send
            ChatTextBox.KeyDown += ChatTextBox_KeyDown;

            button1.MouseClick += button1_MouseClick;

        }


        //сверталка
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(Allowshowdisplay ? value : Allowshowdisplay);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Allowshowdisplay = true;
                Visible = !Visible;
            }
        }

        private void chat_Load(object sender, EventArgs e)
        {
            //var broadcastAddress = MainWindow.passtext;
            textBox1.Text = MainWindow.Passtext;
        }

        private void InitializeSender()
        {
            //int ipAddress = BitConverter.ToInt32(IPAddress.Parse(EnterIPTextBox.Text).GetAddressBytes(), 0); /*преобразовать ІР в інт*/
            //string broadcastAddress = new IPAddress(BitConverter.GetBytes(ipAddress)).ToString();

            //IPAddress addr;
            //IPAddress.TryParse(broadcastAddress, out addr);


            //sendingClient = new UdpClient();
            //sendingClient.Connect(MainWindow.passtext, charport);


            //IPAddress broadcastAddress;
            //IPAddress.TryParse(textBox1.Text, out broadcastAddress);
            //try
            //{
            //    sendingClient.Connect(broadcastAddress, port);
            //}
            //catch
            //{
            //}
            _udpClient = new UdpClient(MainWindow.Passtext, Charport);
            _udpClient.EnableBroadcast = true;

            //var host = Dns.GetHostName();
            //IPAddress ip = Dns.GetHostEntry(host).AddressList[1];
            try
            {
                //IPAddress ipv4Address = Array.FindLast(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);

                // після відкриття порта пробрасую його через роутер
                NATUPNPLib.IStaticPortMappingCollection mappings = upnpnat.StaticPortMappingCollection;
                mappings.Add(Charport, "UDP", Charport, MainWindow.GetLocalAdress().ToString(), true, "SparkleChat UDP Port");
            }
            catch (Exception z)
            {
                MessageBox.Show(z.ToString());
                throw;
            }
        }

        private void InitializeReceiver()
        {
            _receivingClient = new UdpClient(Charport);

            ThreadStart start = Receiver;
            _receivingThread = new Thread(start);
            _receivingThread.IsBackground = true;
            _receivingThread.Start();
        }

        /*private void GetOtherFormTextBox()
        {
            try
            {
                var addrs = otherForm.EnterIPTextBox.Text;
                textBox1.Text = addrs;
            }
            catch (Exception)
            {
                MessageBox.Show("Error with IP");
            }
            //string y = otherForm.EnterIPTextBox.Text;
        }*/

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //GetOtherFormTextBox();
        //    WindowState = FormWindowState.Minimized;
        //}

        //chat


        //send enter
        private void ChatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChatSendButton_Click(sender, e);
            }
            if (ChatTextBox.TextLength > 0)
            {
                ChatTextBox.Text = ChatTextBox.Text.TrimStart();
            }
        }

        //private void CheckEnter(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        ChatSendButton_Click(sender, e);
        //    }
        //    //ChatTextBox.Text = ChatTextBox.Text.TrimEnd(); профіксить перекид
        //    //ChatTextBox.Text = string.Empty;
        //}

        private void ChatSendButton_Click(object sender, EventArgs e)
        {
            //InitializeSender();

            ChatTextBox.Text = ChatTextBox.Text.TrimEnd();
            var userName = MainWindow.Passtext;
            if (!string.IsNullOrEmpty(ChatTextBox.Text))
            {
                var toSend = userName + ":" + Environment.NewLine + ChatTextBox.Text;
                var yousend = "You" + ":" + Environment.NewLine + ChatTextBox.Text;
                var data = Encoding.UTF8.GetBytes(toSend);
                _udpClient.Send(data, data.Length);
                ChatTextBox.Text = "";

                Receiver_TextBox.Text += yousend + Environment.NewLine;
            }
            ChatTextBox.Focus();
        }

        private void Receiver()
        {
            var endPoint = new IPEndPoint(IPAddress.Any, Charport);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                var data = _receivingClient.Receive(ref endPoint);
                var message = Encoding.UTF8.GetString(data);
                Invoke(messageDelegate, message);
            }
        }

        private void MessageReceived(string message)
        {
            Receiver_TextBox.Text += message + /*Environment.NewLine + */Environment.NewLine;
        }

        private void Receiver_TextBox_TextChanged(object sender, EventArgs e)
        {
            Receiver_TextBox.SelectionStart = Receiver_TextBox.Text.Length;
            Receiver_TextBox.ScrollToCaret();
        }

        private delegate void AddMessage(string message);

        public static void Upnpclose()
        {
            NATUPNPLib.IStaticPortMappingCollection mappings = upnpnat.StaticPortMappingCollection;
            mappings.Remove(Charport, "UDP");
        }
    }
}