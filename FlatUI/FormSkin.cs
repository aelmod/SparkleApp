using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FormSkin : ContainerControl
    {
        private readonly int MoveHeight = 50;
        private readonly Color TextColor = Color.FromArgb(234, 234, 234);
        private Color _BaseLight = Color.FromArgb(196, 199, 200);

        private Color _HeaderLight = Color.FromArgb(171, 171, 172);
        private bool Cap;
        private int H;
        private Point MousePoint = new Point(0, 0);
        public Color TextLight = Color.FromArgb(45, 47, 49);
        private int W;

        public FormSkin()
        {
            MouseDoubleClick += FormSkin_MouseDoubleClick;
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 12);
        }

        [Category("Colors")]
        public Color HeaderColor { get; set; } = Color.FromArgb(45, 47, 49);

        [Category("Colors")]
        public Color BaseColor { get; set; } = Color.FromArgb(60, 70, 73);

        [Category("Colors")]
        public Color BorderColor { get; set; } = Color.FromArgb(53, 58, 60);

        [Category("Colors")]
        public Color FlatColor { // get { return Helpers.FlatColor; }
            // set { Helpers.FlatColor = value; }
            get; set; } = Helpers.FlatColor;

        [Category("Options")]
        public bool HeaderMaximize { get; set; } = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left & new Rectangle(0, 0, Width, MoveHeight).Contains(e.Location))
            {
                Cap = true;
                MousePoint = e.Location;
            }
        }

        private void FormSkin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (HeaderMaximize)
            {
                if (e.Button == MouseButtons.Left & new Rectangle(0, 0, Width, MoveHeight).Contains(e.Location))
                {
                    if (FindForm().WindowState == FormWindowState.Normal)
                    {
                        FindForm().WindowState = FormWindowState.Maximized;
                        FindForm().Refresh();
                    }
                    else if (FindForm().WindowState == FormWindowState.Maximized)
                    {
                        FindForm().WindowState = FormWindowState.Normal;
                        FindForm().Refresh();
                    }
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Cap = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Cap)
            {
                // Parent.Location = MousePosition - MousePoint;
                Parent.Location = new Point(
                    MousePosition.X - MousePoint.X,
                    MousePosition.Y - MousePoint.Y
                    );
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ParentForm.FormBorderStyle = FormBorderStyle.None;
            ParentForm.AllowTransparency = false;
            ParentForm.TransparencyKey = Color.Fuchsia;
            ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen;
            Dock = DockStyle.Fill;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var B = new Bitmap(Width, Height);
            var G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            var Base = new Rectangle(0, 0, W, H);
            var Header = new Rectangle(0, 0, W, 50);

            var _with2 = G;
            _with2.SmoothingMode = SmoothingMode.HighQuality;
            _with2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with2.Clear(BackColor);

            //-- Base
            _with2.FillRectangle(new SolidBrush(BaseColor), Base);

            //-- Header
            _with2.FillRectangle(new SolidBrush(HeaderColor), Header);

            //-- Logo
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(243, 243, 243)), new Rectangle(8, 16, 4, 18));
            _with2.FillRectangle(new SolidBrush(FlatColor), 16, 16, 4, 18);
            _with2.DrawString(Text, Font, new SolidBrush(TextColor), new Rectangle(26, 15, W, H), Helpers.NearSF);

            //-- Border
            _with2.DrawRectangle(new Pen(BorderColor), Base);

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}