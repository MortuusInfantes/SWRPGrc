using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using SWRPGrc.Classes.MapElements;

namespace SWRPGrc.Classes
{
    public enum MapType
    {
        Square,
        Hexagon
    }

    public class Map
    {
        Bitmap Pallette;
        int[] map;
        int width;
        int height;
        int feetPerSquare;
        MapType maptype;

        AMapElement[] elements;

        virtual public Bitmap GetBmp()
        {
            return null;
        }
    }
}
