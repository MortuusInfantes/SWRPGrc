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
    public partial class CharacterSheet : UserControl
    {
        //private Form1 parent;

        private PlayerCharacter characterSheet;

        public CharacterSheet()  //Form1 parent
        {
            InitializeComponent();
        //    this.parent = parent;
        //    characterSheet = new PlayerCharacter();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            characterSheet.CharacterName = CharacterNameTextBox.Text;
            characterSheet.PlayerName = PlayerNameTextBox.Text;
            characterSheet.Campaign = CampaignTextBox.Text;
            characterSheet.CharacterLevel = ValidateInteger(CharacterLevelTextBox.Text);
            characterSheet.Species = SpeciesTextBox.Text;          
            characterSheet.Age = ValidateInteger(AgeTextBox.Text);
            characterSheet.Gender = GenderTextBox.Text;
            characterSheet.Height = ValidateInteger(HeightTextBox.Text);
            characterSheet.Weight = ValidateInteger(WeightTextBox.Text);
            characterSheet.Eyes = EyesTextBox.Text;
            characterSheet.Hair = HairTextBox.Text;
            characterSheet.Skin = SkinTextBox.Text;
            //add ability scores and modifiers here
            characterSheet.VitalityTotal = ValidateInteger(VitalityTotalTextBox.Text);
            characterSheet.VitalityCurrent = ValidateInteger(CurrentVitalityTextBox.Text);
            characterSheet.WoundsTotal = ValidateInteger(TotalWoundsTextBox.Text);
            characterSheet.WoundsCurrent = ValidateInteger(CurrentWoundsTextBox.Text);
            characterSheet.DefenseTotal = ValidateInteger(DefenseTotalTextBox.Text);
            characterSheet.DefenseClassBonus = ValidateInteger(DefenseClassBonusTextBox.Text);
            characterSheet.DefenseDexterityModifier = ValidateInteger(DefenseDexModTextBox.Text);
            characterSheet.SizeModifier = ValidateInteger(DefenseSizeModTextBox.Text);
            characterSheet.DefenseMiscModifier = ValidateInteger(DefenseMiscModTextBox.Text);
            characterSheet.ArmorCheck = ValidateInteger(ArmorCheckPenaltyTextBox.Text);
            characterSheet.ForcePoints = ValidateInteger(ForcePointsTextBox.Text);
            characterSheet.DarkSidePoints = ValidateInteger(DarkSidePointsTextBox.Text);
            characterSheet.FortitudeTotal = ValidateInteger(FortitudeTotalTextBox.Text);
            characterSheet.FortitudeBaseSave = ValidateInteger(FortitudeBaseSavetextBox.Text);
            characterSheet.FortitudeAbilityModifier = ValidateInteger(FortitudeAbilityModTextBox.Text);
            characterSheet.FortitudeMiscModifier = ValidateInteger(FortitudeMiscModTextBox.Text);
            characterSheet.ReflexTotal = ValidateInteger(ReflexTotalTextBox.Text);
            characterSheet.ReflexBaseSave = ValidateInteger(ReflexBaseSavetextBox.Text);
            characterSheet.ReflexMiscModifier = ValidateInteger(ReflexMiscModTextBox.Text);
            characterSheet.ReflexAbilityModifier = ValidateInteger(ReflexAbilityModTextBox.Text);
            characterSheet.WillTotal = ValidateInteger(WillTotalTextBox.Text);
            characterSheet.WillBaseSave = ValidateInteger(WillBaseSavetextBox.Text);
            characterSheet.WillAbilityModifier = ValidateInteger(WillAbilityModTextBox.Text);
            characterSheet.WillMiscModifier = ValidateInteger(WillMiscModTextBox.Text);
            characterSheet.MeleeTotal = ValidateInteger(MeleeTotalTextBox.Text);
            characterSheet.MeleeBase = ValidateInteger(MeleeBaseTextBox.Text);
            characterSheet.MeleeStrengthModifier = ValidateInteger(MeleeStrModTextBox.Text);
            characterSheet.MeleeSizeModifier = ValidateInteger(MeleeSizeModTextBox.Text);
            characterSheet.MeleeMiscModifier = ValidateInteger(MeleeMiscModTextBox.Text);
            characterSheet.RangeTotal = ValidateInteger(RangeTotalTextBox.Text);
            characterSheet.RangeBase = ValidateInteger(RangeBaseTextBox.Text);
            characterSheet.RangeDexterityModifier = ValidateInteger(RangeDexModtextBox.Text);
            characterSheet.RangeSizeModifier = ValidateInteger(RangeSizeModtextBox.Text);
            characterSheet.RangeMiscModifier = ValidateInteger(RangeMiscModTextBox.Text);
        }

        private void CalculateTotalDefense()
        {
            DefenseTotalTextBox.Text = (ValidateInteger(DefenseDexModTextBox.Text, true) + ValidateInteger(DefenseClassBonusTextBox.Text, true) + ValidateInteger(DefenseSizeModTextBox.Text, true) + ValidateInteger(DefenseMiscModTextBox.Text, true)).ToString();
        }

        private void CalculateTotalInitiative()
        {
            InitiativeTotalTextBox.Text = (ValidateInteger(InitiativeDexModTextBox.Text, true) + ValidateInteger(InitativeMiscModTextBox.Text, true)).ToString();
        }

        private void CalculateTotalFortitude()
        {
            FortitudeTotalTextBox.Text = (ValidateInteger(FortitudeBaseSavetextBox.Text, true) + ValidateInteger(FortitudeAbilityModTextBox.Text, true) + ValidateInteger(FortitudeMiscModTextBox.Text, true)).ToString();
        }
        
        private void CalculateTotalReflex()
        {
            ReflexTotalTextBox.Text = (ValidateInteger(ReflexBaseSavetextBox.Text, true) + ValidateInteger(ReflexAbilityModTextBox.Text, true) + ValidateInteger(ReflexMiscModTextBox.Text, true)).ToString();
        }

        private void CalculateTotalWill()
        {
            WillTotalTextBox.Text = (ValidateInteger(WillBaseSavetextBox.Text, true) + ValidateInteger(WillAbilityModTextBox.Text, true) + ValidateInteger(WillMiscModTextBox.Text, true)).ToString();
        }

        private void CalculateTotalMelee()
        {
            MeleeTotalTextBox.Text = (ValidateInteger(MeleeBaseTextBox.Text, true) + ValidateInteger(MeleeStrModTextBox.Text, true) + ValidateInteger(MeleeSizeModTextBox.Text, true) + ValidateInteger(MeleeMiscModTextBox.Text, true)).ToString();
        }

        private void CalculateTotalRanged()
        {
            RangeTotalTextBox.Text = (ValidateInteger(RangeBaseTextBox.Text, true) + ValidateInteger(RangeDexModtextBox.Text, true) + ValidateInteger(RangeSizeModtextBox.Text, true) + ValidateInteger(RangeMiscModTextBox.Text, true)).ToString();
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

        private void DefenseModifier_Leave(object sender, EventArgs e)
        {
            CalculateTotalDefense();
        }

        private void InitiativeDexModTextBox_Leave(object sender, EventArgs e)
        {
            CalculateTotalInitiative();
        }

        private void FortitudeBaseSavetextBox_Leave(object sender, EventArgs e)
        {
            CalculateTotalFortitude();
        }

        private void ReflexBaseSavetextBox_Leave(object sender, EventArgs e)
        {
            CalculateTotalReflex();
        }

        private void WillBaseSavetextBox_Leave(object sender, EventArgs e)
        {
            CalculateTotalWill();
        }        
    }

    public class ValidationException : Exception
    {

    }
}
