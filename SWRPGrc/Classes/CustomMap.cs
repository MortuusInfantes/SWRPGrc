using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SWRPGrc.Classes
{
    public class CustomMap : Map
    {
        public override System.Drawing.Bitmap GetBmp()
        {
            Bitmap newBmp = new Bitmap(1000, 1000);
            Graphics g = Graphics.FromImage(newBmp);
            g.FillRectangle(new SolidBrush(Color.Blue),0,0,1000, 1000);

            return newBmp;
        }
    }
}
