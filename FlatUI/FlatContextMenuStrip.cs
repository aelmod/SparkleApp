using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FlatContextMenuStrip : ContextMenuStrip
    {
        public FlatContextMenuStrip()
        {
            Renderer = new ToolStripProfessionalRenderer(new TColorTable());
            ShowImageMargin = false;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 8);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        }

        public class TColorTable : ProfessionalColorTable
        {
            [Category("Colors")]
            public Color _BackColor { get; set; } = Color.FromArgb(45, 47, 49);

            [Category("Colors")]
            public Color _CheckedColor { get; set; } = Helpers.FlatColor;

            [Category("Colors")]
            public Color _BorderColor { get; set; } = Color.FromArgb(53, 58, 60);

            public override Color ButtonSelectedBorder
            {
                get { return _BackColor; }
            }

            public override Color CheckBackground
            {
                get { return _CheckedColor; }
            }

            public override Color CheckPressedBackground
            {
                get { return _CheckedColor; }
            }

            public override Color CheckSelectedBackground
            {
                get { return _CheckedColor; }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return _CheckedColor; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return _CheckedColor; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return _CheckedColor; }
            }

            public override Color MenuBorder
            {
                get { return _BorderColor; }
            }

            public override Color MenuItemBorder
            {
                get { return _BorderColor; }
            }

            public override Color MenuItemSelected
            {
                get { return _CheckedColor; }
            }

            public override Color SeparatorDark
            {
                get { return _BorderColor; }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return _BackColor; }
            }
        }
    }
}