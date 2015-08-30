using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Generators.StandPack
{
    public partial class StandPackMain : UserControl
    {
        public StandPackMain()
        {
            InitializeComponent();
        }

        private void StandPackMain_Load(object sender, EventArgs e)
        {
            TxtBxstatOne.Text = "15";
            TxtBxStatTwo.Text = "14";
            TxtBxStatThree.Text = "13";
            TxtBxStatFour.Text = "12";
            TxtBxStatFive.Text = "10";
            TxtBxStatSix.Text = "8";
        }
    }
}
