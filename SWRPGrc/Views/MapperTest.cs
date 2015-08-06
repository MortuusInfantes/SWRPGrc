using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SWRPGrc.Classes;

namespace SWRPGrc.Views
{
    public partial class MapperTest : Mapper
    {

        public MapperTest(Form1 parent) : base(parent, true)
        {
            base.map = new CustomMap();
        }
    }
}
