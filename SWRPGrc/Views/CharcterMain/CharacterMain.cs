using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views.CharcterMain
{
    public partial class CharacterMain : UserControl
    {
        public CharacterMain()
        {
            InitializeComponent();
        }

        private void BtnCharTemp_Click(object sender, EventArgs e)
        {
            PnlCharMain.Controls.Clear();
            PnlCharMain.Controls.Add(new SWRPGrc.Views.CharacterSheet());
        }

        private void BtnNewChar_Click(object sender, EventArgs e)
        {
            PnlCharMain.Controls.Clear();
            PnlCharMain.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpeciesMain());
        }
    }
}
