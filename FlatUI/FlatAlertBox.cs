﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FlatAlertBox : Control
    {
        [Flags]
        public enum _Kind
        {
            Success,
            Error,
            Info
        }

        private readonly Color ErrorColor = Color.FromArgb(87, 71, 71);
        private readonly Color ErrorText = Color.FromArgb(254, 142, 122);
        private readonly Color InfoColor = Color.FromArgb(70, 91, 94);
        private readonly Color InfoText = Color.FromArgb(97, 185, 186);

        private readonly Color SuccessColor = Color.FromArgb(60, 85, 79);
        private readonly Color SuccessText = Color.FromArgb(35, 169, 110);

        private string _Text;
        private int H;
        private MouseState State = MouseState.None;

        /// <summary>
        ///     How to use: FlatAlertBox.ShowControl(Kind, String, Interval)
        /// </summary>
        /// <remarks></remarks>
        private int W;

        private Timer withEventsField_T;
        private int X;

        public FlatAlertBox()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(60, 70, 73);
            Size = new Size(576, 42);
            Location = new Point(10, 61);
            Font = new Font("Segoe UI", 10);
            Cursor = Cursors.Hand;
        }

        private Timer T
        {
            get { return withEventsField_T; }
            set
            {
                if (withEventsField_T != null)
                {
                    withEventsField_T.Tick -= T_Tick;
                }
                withEventsField_T = value;
                if (withEventsField_T != null)
                {
                    withEventsField_T.Tick += T_Tick;
                }
            }
        }

        [Category("Options")]
        public _Kind kind { get; set; }

        [Category("Options")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                if (_Text != null)
                {
                    _Text = value;
                }
            }
        }

        [Category("Options")]
        public new bool Visible
        {
            get { return base.Visible == false; }
            set { base.Visible = value; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 42;
        }

        public void ShowControl(_Kind Kind, string Str, int Interval)
        {
            kind = Kind;
            Text = Str;
            Visible = true;
            T = new Timer();
            T.Interval = Interval;
            T.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Visible = false;
            T.Enabled = false;
            T.Dispose();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            X = e.X;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Visible = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var B = new Bitmap(Width, Height);
            var G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            var Base = new Rectangle(0, 0, W, H);

            var _with14 = G;
            _with14.SmoothingMode = SmoothingMode.HighQuality;
            _with14.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with14.Clear(BackColor);

            switch (kind)
            {
                case _Kind.Success:
                    //-- Base
                    _with14.FillRectangle(new SolidBrush(SuccessColor), Base);

                    //-- Ellipse
                    _with14.FillEllipse(new SolidBrush(SuccessText), new Rectangle(8, 9, 24, 24));
                    _with14.FillEllipse(new SolidBrush(SuccessColor), new Rectangle(10, 11, 20, 20));

                    //-- Checked Sign
                    _with14.DrawString("ü", new Font("Wingdings", 22), new SolidBrush(SuccessText),
                        new Rectangle(7, 7, W, H), Helpers.NearSF);
                    _with14.DrawString(Text, Font, new SolidBrush(SuccessText), new Rectangle(48, 12, W, H),
                        Helpers.NearSF);

                    //-- X button
                    _with14.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)),
                        new Rectangle(W - 30, H - 29, 17, 17));
                    _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(SuccessColor),
                        new Rectangle(W - 28, 16, W, H), Helpers.NearSF);

                    switch (State)
                    {
                        // -- Mouse Over
                        case MouseState.Over:
                            _with14.DrawString("r", new Font("Marlett", 8),
                                new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(W - 28, 16, W, H),
                                Helpers.NearSF);
                            break;
                    }

                    break;
                case _Kind.Error:
                    //-- Base
                    _with14.FillRectangle(new SolidBrush(ErrorColor), Base);

                    //-- Ellipse
                    _with14.FillEllipse(new SolidBrush(ErrorText), new Rectangle(8, 9, 24, 24));
                    _with14.FillEllipse(new SolidBrush(ErrorColor), new Rectangle(10, 11, 20, 20));

                    //-- X Sign
                    _with14.DrawString("r", new Font("Marlett", 16), new SolidBrush(ErrorText),
                        new Rectangle(6, 11, W, H), Helpers.NearSF);
                    _with14.DrawString(Text, Font, new SolidBrush(ErrorText), new Rectangle(48, 12, W, H),
                        Helpers.NearSF);

                    //-- X button
                    _with14.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)),
                        new Rectangle(W - 32, H - 29, 17, 17));
                    _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(ErrorColor),
                        new Rectangle(W - 30, 17, W, H), Helpers.NearSF);

                    switch (State)
                    {
                        case MouseState.Over:
                            // -- Mouse Over
                            _with14.DrawString("r", new Font("Marlett", 8),
                                new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(W - 30, 15, W, H),
                                Helpers.NearSF);
                            break;
                    }

                    break;
                case _Kind.Info:
                    //-- Base
                    _with14.FillRectangle(new SolidBrush(InfoColor), Base);

                    //-- Ellipse
                    _with14.FillEllipse(new SolidBrush(InfoText), new Rectangle(8, 9, 24, 24));
                    _with14.FillEllipse(new SolidBrush(InfoColor), new Rectangle(10, 11, 20, 20));

                    //-- Info Sign
                    _with14.DrawString("¡", new Font("Segoe UI", 20, FontStyle.Bold), new SolidBrush(InfoText),
                        new Rectangle(12, -4, W, H), Helpers.NearSF);
                    _with14.DrawString(Text, Font, new SolidBrush(InfoText), new Rectangle(48, 12, W, H), Helpers.NearSF);

                    //-- X button
                    _with14.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)),
                        new Rectangle(W - 32, H - 29, 17, 17));
                    _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(InfoColor),
                        new Rectangle(W - 30, 17, W, H), Helpers.NearSF);

                    switch (State)
                    {
                        case MouseState.Over:
                            // -- Mouse Over
                            _with14.DrawString("r", new Font("Marlett", 8),
                                new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(W - 30, 17, W, H),
                                Helpers.NearSF);
                            break;
                    }
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}