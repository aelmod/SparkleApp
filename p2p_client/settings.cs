using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2p_client
{
    public partial class settings : Form
    {
        private int x; //переміщення за панель [START]
        private int y;

        public settings()
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
    }
}
