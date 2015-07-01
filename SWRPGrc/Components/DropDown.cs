using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Components
{
    public partial class DropDown : UserControl
    {
        public string Title { get { return lblName.Text; } set { lblName.Text = value; } }


        public DropDown()
        {
            InitializeComponent();
        }
    }
}
