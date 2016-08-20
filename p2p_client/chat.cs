using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace p2p_client
{
    public partial class chat : Form
    {
        private const int charport = 54545/*54236*//*43585*/;
        //private readonly string userName = broadcastAddress;
        //private string _broadcastAddress = "127.0.0.1";
        public bool allowshowdisplay = MainWindow.allowshowdisplay;

        //private readonly MainWindow otherForm = new MainWindow();
        private UdpClient receivingClient;
        private Thread receivingThread;
        private UdpClient udpClient;

        NATUPNPLib.UPnPNATClass upnpnat = new NATUPNPLib.UPnPNATClass();

        public chat()
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
            base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                allowshowdisplay = true;
                Visible = !Visible;
            }
        }

        private void chat_Load(object sender, EventArgs e)
        {
            //var broadcastAddress = MainWindow.passtext;
            textBox1.Text = MainWindow.passtext;
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
            udpClient = new UdpClient(MainWindow.passtext, charport);
            udpClient.EnableBroadcast = true;

            var host = Dns.GetHostName();
            IPAddress ip = Dns.GetHostEntry(host).AddressList[1];

            // після відкриття порта, пробрасую через роутер
            NATUPNPLib.IStaticPortMappingCollection mappings = upnpnat.StaticPortMappingCollection;
            mappings.Add(charport, "UDP", charport, ip.ToString(), true, "Chat Open Port");
        }

        private void InitializeReceiver()
        {
            receivingClient = new UdpClient(charport);

            ThreadStart start = Receiver;
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
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
            var userName = MainWindow.passtext;
            if (!string.IsNullOrEmpty(ChatTextBox.Text))
            {
                var toSend = userName + ":" + Environment.NewLine + ChatTextBox.Text;
                var yousend = "You" + ":" + Environment.NewLine + ChatTextBox.Text;
                var data = Encoding.UTF8.GetBytes(toSend);
                udpClient.Send(data, data.Length);
                ChatTextBox.Text = "";

                Receiver_TextBox.Text += yousend + Environment.NewLine;
            }
            ChatTextBox.Focus();
        }

        private void Receiver()
        {
            var endPoint = new IPEndPoint(IPAddress.Any, charport);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                var data = receivingClient.Receive(ref endPoint);
                var message = Encoding.UTF8.GetString(data);
                Invoke(messageDelegate, message);
            }
        }

        private void MessageReceived(string message)
        {
            Receiver_TextBox.Text += message + /*Environment.NewLine + */ Environment.NewLine;
        }

        private void Receiver_TextBox_TextChanged(object sender, EventArgs e)
        {
            Receiver_TextBox.SelectionStart = Receiver_TextBox.Text.Length;
            Receiver_TextBox.ScrollToCaret();
        }

        private delegate void AddMessage(string message);
    }
}