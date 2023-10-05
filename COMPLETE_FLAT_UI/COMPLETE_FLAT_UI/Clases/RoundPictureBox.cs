using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace COMPLETE_FLAT_UI.Clases
{
   public class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            //GraphicsPath grpath = new GraphicsPath();
            ////grpath.AddEllipse(0, 0, Width, ClientSize.Height);
            //grpath.AddEllipse(0, 0, this.Width - 1, this.Height - 1);

            //this.Region = new System.Drawing.Region(grpath);
            //base.OnPaint(pe);

            //otra manera
            //======================
            base.OnPaint(pe);
            using (GraphicsPath obj = new GraphicsPath())
            {
                obj.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                Region = new Region(obj);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
            }
            //======================
        }
    }
}
