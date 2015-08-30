using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Generators.PlannedGen
{
    public partial class PlannedGenMain : UserControl
    {
        public PlannedGenMain()
        {
            InitializeComponent();
        }

        private void PlannedGenMain_Load(object sender, EventArgs e)
        {
            TxtBxScoreOne.Text = "8";
            TxtBxScoreTwo.Text = "8";
            TxtBxScoreThree.Text = "8";
            TxtBxScoreFour.Text = "8";
            TxtBxScoreFive.Text = "8";
            TxtBxScoreSix.Text = "8";
            TxtBxAvaPoints.Text = "25";

        }

        private void BtnScOnePlus_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreOne.Text,true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch(scoreone)
            {
                case 8:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    
                    break;
                case 9:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 10:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 11:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 12:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 13:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 14:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 15:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 16:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 17:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 18:
                    MessageBox.Show("Cannot increase ability score. At max capacity.");
                    break;
            }
            TxtBxScoreOne.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScTwoPlus_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreTwo.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;

                    break;
                case 9:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 10:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 11:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 12:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 13:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 14:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 15:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 16:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 17:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 18:
                    MessageBox.Show("Cannot increase ability score. At max capacity.");
                    break;
            }
            TxtBxScoreTwo.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScThreePlus_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreThree.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;

                    break;
                case 9:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 10:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 11:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 12:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 13:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 14:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 15:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 16:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 17:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 18:
                    MessageBox.Show("Cannot increase ability score. At max capacity.");
                    break;
            }
            TxtBxScoreThree.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScFourPlus_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreFour.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;

                    break;
                case 9:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 10:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 11:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 12:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 13:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 14:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 15:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 16:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 17:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 18:
                    MessageBox.Show("Cannot increase ability score. At max capacity.");
                    break;
            }
            TxtBxScoreFour.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScFivePlus_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreFive.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;

                    break;
                case 9:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 10:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 11:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 12:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 13:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 14:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 15:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 16:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 17:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 18:
                    MessageBox.Show("Cannot increase ability score. At max capacity.");
                    break;
            }
            TxtBxScoreFive.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScSixPlus_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreSix.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;

                    break;
                case 9:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 10:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 11:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 12:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 13:
                    scoreone = scoreone + 1;
                    leftover = leftover - 1;
                    break;
                case 14:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 15:
                    scoreone = scoreone + 1;
                    leftover = leftover - 2;
                    break;
                case 16:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 17:
                    scoreone = scoreone + 1;
                    leftover = leftover - 3;
                    break;
                case 18:
                    MessageBox.Show("Cannot increase ability score. At max capacity.");
                    break;
            }
            TxtBxScoreSix.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScOneMin_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreOne.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    MessageBox.Show("Cannot decrease ability score. At min capacity.");
                    break;
                case 9:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 10:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 11:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 12:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 13:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 14:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 15:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 16:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 17:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
                case 18:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
            }
            TxtBxScoreOne.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScTwoMin_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreTwo.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    MessageBox.Show("Cannot decrease ability score. At min capacity.");
                    break;
                case 9:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 10:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 11:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 12:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 13:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 14:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 15:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 16:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 17:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
                case 18:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
            }
            TxtBxScoreTwo.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScThreeMin_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreThree.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    MessageBox.Show("Cannot decrease ability score. At min capacity.");
                    break;
                case 9:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 10:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 11:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 12:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 13:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 14:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 15:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 16:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 17:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
                case 18:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
            }
            TxtBxScoreThree.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScFourMin_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreFour.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    MessageBox.Show("Cannot decrease ability score. At min capacity.");
                    break;
                case 9:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 10:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 11:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 12:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 13:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 14:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 15:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 16:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 17:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
                case 18:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
            }
            TxtBxScoreFour.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScFiveMin_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreFive.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    MessageBox.Show("Cannot decrease ability score. At min capacity.");
                    break;
                case 9:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 10:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 11:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 12:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 13:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 14:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 15:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 16:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 17:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
                case 18:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
            }
            TxtBxScoreFive.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private void BtnScSixMin_Click(object sender, EventArgs e)
        {
            int scoreone = ValidateInteger(TxtBxScoreSix.Text, true);
            int leftover = ValidateInteger(TxtBxAvaPoints.Text, true);
            switch (scoreone)
            {
                case 8:
                    MessageBox.Show("Cannot decrease ability score. At min capacity.");
                    break;
                case 9:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 10:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 11:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 12:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 13:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 14:
                    scoreone = scoreone - 1;
                    leftover = leftover + 1;
                    break;
                case 15:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 16:
                    scoreone = scoreone - 1;
                    leftover = leftover + 2;
                    break;
                case 17:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
                case 18:
                    scoreone = scoreone - 1;
                    leftover = leftover + 3;
                    break;
            }
            TxtBxScoreSix.Text = (scoreone).ToString();
            TxtBxAvaPoints.Text = (leftover).ToString();
        }

        private int ValidateInteger(string s)
        {
            int output;
            if (!Int32.TryParse(s, out output))
                throw new ValidationException();
            return output;
        }

        private int ValidateInteger(string s, bool blankAsZero)
        {
            int output;
            if (s == "")
                return 0;
            if (!Int32.TryParse(s, out output))
                throw new ValidationException();
            return output;
        }

        private bool ValidateBoolean(string s)
        {
            bool output;
            if (!Boolean.TryParse(s, out output))
                throw new ValidationException();
            return output;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(TxtBxAvaPoints.Text == "0")
            {
            
            BtnScOnePlus.Enabled = false;
            }
            else
            {
                MessageBox.Show("Total available points doenst = 0");

            }

        }
    }
}
