using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

            SettingsTabControl.MouseDown += SettingsTabControl_MouseDown;
            SettingsTabControl.MouseMove += SettingsTabControl_MouseMove;

        }

        // Нажатие кнопки мышки
        private void SettingsTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        // Движение мышки
        private void SettingsTabControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            }
        }   //переміщення за панель [END]


        private void settings_Load(object sender, EventArgs e)
        {
            //ip array
            IPAddress[] ipv4Addresses = Array.FindAll(
            Dns.GetHostEntry(string.Empty).AddressList,
            a => a.AddressFamily == AddressFamily.InterNetwork);
            foreach (var VARIABLE in ipv4Addresses)
            {
                label3.Text = VARIABLE.ToString();
            }
            //or use Array.Find or Array.FindLast if you just want one.
        }
    }
}
