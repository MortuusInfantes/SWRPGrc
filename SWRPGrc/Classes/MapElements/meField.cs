using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SWRPGrc.Classes.MapElements
{
    public class meField : AMapElement
    {
        private Point Start = new Point(0,0);
        private Point Finish = new Point(1000,1000);
        private int width = 10;

        public meField(Bitmap bmp)
        {
            base.bmp = bmp;
        }

        public override void RenderElement()
        {
            
        }
    }
}
