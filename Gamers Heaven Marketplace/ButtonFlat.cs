using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Gamers_Heaven_Marketplace
{
    class ButtonFlat: Button
    {
        public ButtonFlat()
        {
            BackColor = ColorTranslator.FromHtml("#1e262c");
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, this.Width, this.Height));
            TextFormatFlags flag = TextFormatFlags.HorizontalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, new Font("Verdana", 12, FontStyle.Regular), new Point(Width + 3, this.Height / 2 - 10), Color.White, flag);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = ColorTranslator.FromHtml("#4b5259");
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = ColorTranslator.FromHtml("#1e262c");
        }
    }
}
