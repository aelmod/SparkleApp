using System.Drawing;
using System.Windows.Forms;

namespace p2p_client
{
    public partial class UDP_P2P : Form
    {
        //переміщення за панель [START]
        private int x;
        private int y;

        public UDP_P2P()
        {
            InitializeComponent();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
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
        }

        //переміщення за панель [END]
    }
}