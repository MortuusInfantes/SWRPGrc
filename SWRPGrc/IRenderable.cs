using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWRPGrc
{
    public interface IRenderable
    {
        int drawObject(System.Drawing.Bitmap target);
    }
}
