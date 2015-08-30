using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views.CharcterMain.NewCharacter
{
    public partial class ScoreClassSpeciesMain : UserControl
    {
        public ScoreClassSpeciesMain()
        {
            InitializeComponent();
        }

        private void ScoreClassSpeciesMain_Load(object sender, EventArgs e)
        {
            PnlScore.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.ScoreMain());
        }
    }
}
