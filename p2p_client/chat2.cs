using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using p2p_client.Properties;

namespace p2p_client
{
    public partial class chat2 : Form
    {
        //переміщення за панель [START]
        private int x;
        private int y;

        private static IPAddress remoteIPAddress;
        private static int remotePort;
        private static int localPort;

        public chat2()
        {
            InitializeComponent();

            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;

            label1.MouseDown += panel1_MouseDown;
            label1.MouseMove += panel1_MouseMove;

            pictureBox1.MouseDown += panel1_MouseDown;
            pictureBox1.MouseMove += panel1_MouseMove;

        }

        // Нажатие кнопки мышки
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        // Движение мышки
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            }
        }   //переміщення за панель [END]



        private void chat2_Load(object sender, EventArgs e)
        {
        }

     }
}