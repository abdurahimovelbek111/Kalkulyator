using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Kalkulyator1998
{
    class aylanaButton:Button
    {
        protected override void OnPaint(PaintEventArgs Elbek)
        {
            GraphicsPath aylanacha = new GraphicsPath();
            aylanacha.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(aylanacha);
            base.OnPaint(Elbek);
        }

    }
}
