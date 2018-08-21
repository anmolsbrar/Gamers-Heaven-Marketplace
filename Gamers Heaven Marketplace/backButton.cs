using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamers_Heaven_Marketplace
{
    class backButton: Button
    {

        public backButton()
        {
            Image = Gamers_Heaven_Marketplace.Properties.Resources.backNormal;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 38, 44);
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 38, 44);
            this.Height = 23;
            this.Width = 23;
            this.Text = "";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Image = Gamers_Heaven_Marketplace.Properties.Resources.backNormal;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Image = Gamers_Heaven_Marketplace.Properties.Resources.backGlow;
        }

    }
}
