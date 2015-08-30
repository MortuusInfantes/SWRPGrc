using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score
{
    public partial class ScoreMain : UserControl
    {
        public ScoreMain()
        {
            InitializeComponent();
        }
        
        private void RadButRandom_CheckedChanged(object sender, EventArgs e)
        {
            PnlScoreInfo.Controls.Clear();
            PnlScoreInfo.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Random.RandomInfo());
        }

        private void RadButPlanGen_CheckedChanged(object sender, EventArgs e)
        {
            PnlScoreInfo.Controls.Clear();
            PnlScoreInfo.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Info.PlannedGenInfo());
        }

        private void RadButStandScor_CheckedChanged(object sender, EventArgs e)
        {
            PnlScoreInfo.Controls.Clear();
            PnlScoreInfo.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Info.StndPackInfo());
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

        private void TxtBxSelect_Click(object sender, EventArgs e)
        {
            if(RadButRandom.Checked== true)
            {
                DisposeAllControls();
                this.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Generators.Random.RandomMain());   //this is an example of some code that may work

            }
            else if(RadButPlanGen.Checked ==true)
            {
                DisposeAllControls();
                this.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Generators.PlannedGen.PlannedGenMain());
            }
            else if(RadButStandScor.Checked == true)
            {
                DisposeAllControls();
                this.Controls.Add(new SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Generators.StandPack.StandPackMain());
            }
        }

        
    }
}
