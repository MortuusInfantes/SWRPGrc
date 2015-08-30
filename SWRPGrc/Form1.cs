using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(new SWRPGrc.Views.MainMenu());
        }

        public void DisposeAllControls()
        {
            while (this.Controls.Count > 0)
            {
                foreach (Control c in this.Controls)
                {
                    c.Dispose();
                }
            }
        }

        public void NavigateToCharacterSheet()
        {
            DisposeAllControls();
            //this.Controls.Add(new SWRPGrc.Views.CharacterSheet(this));
        }

        public void NavigateToMapper()
        {
            DisposeAllControls();
            this.Controls.Add(new SWRPGrc.Views.MapperTest(this));
        }
    }
}
