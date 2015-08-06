using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views
{
    public partial class Welcome : UserControl
    {
        Form1 parent;

        public Welcome(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnCharSheet_Click(object sender, EventArgs e)
        {
            parent.NavigateToCharacterSheet();
        }

        private void btnMapper_Click(object sender, EventArgs e)
        {
            parent.NavigateToMapper();
        }
    }
}
