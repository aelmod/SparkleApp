using System;
using System.Drawing;
using System.Windows.Forms;
using p2p_client;

namespace SparkleApp
{
    public partial class Udpp2P : Form
    {
        //private static readonly object locker = new object();

        private int _x; //переміщення за панель [START]
        private int _y;

        public Udpp2P()
        {
            InitializeComponent();

            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;

            label3.MouseDown += panel1_MouseDown;
            label3.MouseMove += panel1_MouseMove;

            pictureBox1.MouseDown += panel1_MouseDown;
            pictureBox1.MouseMove += panel1_MouseMove;
        }

        // Нажатие кнопки мышки
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
        }

        // Движение мышки
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + (e.X - _x), Location.Y + (e.Y - _y));
            }
        } //переміщення за панель [END]

        private void UDP_P2P_Load(object sender, EventArgs e)
        {
        }

        //public static void chat2_open()
        //{
        //    lock (locker)
        //        Application.Run(new chat2());
        //}

        private chat2 _wnd;

        private void chat_picture_Click(object sender, EventArgs e)
        {
            //var t = new Thread(chat2_open);
            //t.Start();

            if (_wnd == null || _wnd.IsDisposed)
            {
                Action<chat2> fn = w =>
                {
                    w.Left = Left + Width;
                    w.Top = Top;
                };

                _wnd = new chat2
                {
                    Width = 284,
                    Height = 366
                };
                fn(_wnd);
                _wnd.Owner = this;
                _wnd.Show();
                LocationChanged += (s, _) => fn(_wnd);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var f = new settings();
            f.Show();
        }

        private void debug_Click(object sender, EventArgs e)
        {
            var f = new MainWindow();
            f.Show();
        }
    }
}