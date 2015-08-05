using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SWRPGrc.Classes.MapElements
{
    public abstract class AMapElement
    {
        public int zIndex;
        public Bitmap bmp;

        public virtual void RenderElement()
        {
 
        }
    }
}
