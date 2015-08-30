using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score.Generators.Random
{
    //<summary>
    //things to do here: 
    //      convert the dice buttons into one.
    //      stuff for next process.
    //      a toggle for computer rolled or user roll and input
    //</summary>
    
    public partial class RandomMain : UserControl
    {
        int clicks = 0;
        int process = 1;
        public RandomMain()
        {
            InitializeComponent();
        }

        private void BtnDiceOne_Click(object sender, EventArgs e)
        {
            BtnDiceOne.Enabled = false;
            if(clicks == 3)
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll1 = ((rInt).ToString());
                TxtBxDiceOne.Text = roll1;
                Process_Dice();
            }
            else
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll1 =((rInt).ToString());
                TxtBxDiceOne.Text = roll1;
                clicks = clicks + 1;
            }
        }

        private void BtnDiceTwo_Click(object sender, EventArgs e)
        {
            BtnDiceTwo.Enabled = false;
            if (clicks == 3)
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll2 = ((rInt).ToString());
                TxtBxDiceTwo.Text = roll2;
                Process_Dice();
            }
            else
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll2 = ((rInt).ToString());
                TxtBxDiceTwo.Text = roll2;
                clicks = clicks + 1;
            }
        }

        private void BtnDiceThree_Click(object sender, EventArgs e)
        {
            BtnDiceThree.Enabled = false;
            if (clicks == 3)
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll1 = ((rInt).ToString());
                TxtBxDiceThree.Text = roll1;
                Process_Dice();
            }
            else
            {

                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll1 = ((rInt).ToString());
                TxtBxDiceThree.Text = roll1;
                clicks = clicks + 1;
            }
        }

        private void BtnDiceFour_Click(object sender, EventArgs e)
        {
            BtnDiceFour.Enabled = false;
            if (clicks == 3)
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll1 = ((rInt).ToString());
                TxtBxDiceFour.Text = roll1;
                Process_Dice();
            }
            else
            {
                System.Random rnd1 = new System.Random();
                int rInt = rnd1.Next(1, 6);
                string roll1 = ((rInt).ToString());
                TxtBxDiceFour.Text = roll1;
                clicks = clicks + 1;
            }
        }

        private void Process_Dice()
        {
            int roll1 = ValidateInteger(TxtBxDiceOne.Text,true);
            int roll2 = ValidateInteger(TxtBxDiceTwo.Text,true);
            int roll3 = ValidateInteger(TxtBxDiceThree.Text,true);
            int roll4 = ValidateInteger(TxtBxDiceFour.Text,true);
            int[] array = { roll1, roll2, roll3, roll4 };
            int min = array.Min();
            int DiceValue = roll1 + roll2 + roll3 + roll4 - min;
            switch(process)
            {
                case 1:
                    TxtBxRollOne.Text = (DiceValue).ToString();
                    process = process + 1;
                    reset_dice();
                    break;
                case 2:
                    TxtBxRollTwo.Text = (DiceValue).ToString();
                    process = process + 1;
                    reset_dice();
                    break;
                case 3:
                    TxtbxRollThree.Text = (DiceValue).ToString();
                    process = process + 1;
                    reset_dice();
                    break;
                case 4:
                    TxtBxRollFour.Text = (DiceValue).ToString();
                    process = process + 1;
                    reset_dice();
                    break;
                case 5:
                    TxtBxRollFive.Text = (DiceValue).ToString();
                    process = process + 1;
                    reset_dice();
                    break;
                case 6:
                    TxtBxRollSix.Text = (DiceValue).ToString();
                    BtnDiceOne.Enabled = false;
                    BtnDiceTwo.Enabled = false;
                    BtnDiceThree.Enabled = false;
                    BtnDiceFour.Enabled = false;
                    Check_Reroll();
                    break;
            }
        }

        private void Check_Reroll()
        {
            int roll1 = ValidateInteger(TxtBxRollOne.Text,true);
            int roll2 = ValidateInteger(TxtBxRollTwo.Text, true);
            int roll3 = ValidateInteger(TxtbxRollThree.Text, true);
            int roll4 = ValidateInteger(TxtBxRollFour.Text, true);
            int roll5 = ValidateInteger(TxtBxRollFive.Text, true);
            int roll6 = ValidateInteger(TxtBxRollSix.Text, true);

            int[] array = { roll1, roll2, roll3, roll4, roll5, roll6 };
            int max = array.Max();
            if (max <= 13)
            {
                MessageBox.Show("Highest score is " + (max).ToString() + ". Reroll!");
                Reroll();
            }
            else
            {
                double mod1 = -0.0011 * roll1 + 0.5221 * roll1 - 5.3406;
                double mod2 = -0.0011 * roll2 + 0.5221 * roll2 - 5.3406;
                double mod3 = -0.0011 * roll3 + 0.5221 * roll3 - 5.3406;
                double mod4 = -0.0011 * roll4 + 0.5221 * roll4 - 5.3406;
                double mod5 = -0.0011 * roll5 + 0.5221 * roll5 - 5.3406;
                double mod6 = -0.0011 * roll6 + 0.5221 * roll6 - 5.3406;

                double mod1round = Math.Round(mod1);
                double mod2round = Math.Round(mod2);
                double mod3round = Math.Round(mod3);
                double mod4round = Math.Round(mod4);
                double mod5round = Math.Round(mod5);
                double mod6round = Math.Round(mod6);

                double total = mod1round + mod2round + mod3round + mod4round + mod5round + mod6round;
                if (total <= 0)
                {
                    MessageBox.Show("Total ability modifier is " + (total).ToString() + ". Reroll!");
                    Reroll();
                }
            }
        }

        private void Reroll()
        {
            clicks = 0;
            process = 1;

            TxtBxRollOne.Text = "";
            TxtBxRollTwo.Text = "";
            TxtbxRollThree.Text = "";
            TxtBxRollFour.Text = "";
            TxtBxRollFive.Text = "";
            TxtBxRollSix.Text = "";
            BtnDiceOne.Enabled = true;
            BtnDiceTwo.Enabled = true;
            BtnDiceThree.Enabled = true;
            BtnDiceFour.Enabled = true;
            reset_dice();
        }

        private void reset_dice()
        {
            BtnDiceOne.Enabled = true;
            BtnDiceTwo.Enabled = true;
            BtnDiceThree.Enabled = true;
            BtnDiceFour.Enabled = true;
            TxtBxDiceOne.Text = "";
            TxtBxDiceTwo.Text = "";
            TxtBxDiceThree.Text = "";
            TxtBxDiceFour.Text = "";
            clicks = 0;
            
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
    }
}
