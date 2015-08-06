using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWRPGrc.Classes
{
    [DataContract]
    public class PlayerCharacter : Character
    {
        [DataMember]
        public string CharacterName { get; set; }
        [DataMember]
        public string PlayerName { get; set; }
        [DataMember]
        public string Campaign { get; set; }

        [DataMember]
        public int CharacterLevel { get; set; }
        [DataMember]
        public string Species { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public double Height { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public string Eyes { get; set; }
        [DataMember]
        public string Hair { get; set; }
        [DataMember]
        public string Skin { get; set; }

        [DataMember]
        public int VitalityCurrent { get; set; }
        [DataMember]
        public int VitalityTotal { get; set; }
        [DataMember]
        public int WoundsCurrent { get; set; }
        [DataMember]
        public int WoundsTotal { get; set; }
        [DataMember]
        public int DefenseTotal { get; set; }
        [DataMember]
        public int DefenseClassBonus { get; set; }
        [DataMember]
        public int DefenseDexterityModifier { get; set; }
        [DataMember]
        public int SizeModifier { get; set; }
        [DataMember]
        public int DefenseMiscModifier { get; set; }
        [DataMember]
        public int ArmorCheck { get; set; }
        [DataMember]
        public int Speed { get; set; }
        [DataMember]
        public int BaseAttack { get; set; }
        [DataMember]
        public int Reputation { get; set; }
        [DataMember]
        public int InitiativeTotal { get; set; }
        [DataMember]
        public int InitiativeDexterityModifier { get; set; }
        [DataMember]
        public int InitiativeMiscellaneousModifier { get; set; }
        [DataMember]
        public int ForcePoints { get; set; }
        [DataMember]
        public int DarkSidePoints { get; set; }
        [DataMember]
        public int FortitudeTotal { get; set; }
        [DataMember]
        public int FortitudeBaseSave { get; set; }
        [DataMember]
        public int FortitudeAbilityModifier { get; set; }
        [DataMember]
        public int FortitudeMiscModifier { get; set; }
        [DataMember]
        public int ReflexTotal { get; set; }
        [DataMember]
        public int ReflexBaseSave { get; set; }
        [DataMember]
        public int ReflexAbilityModifier { get; set; }
        [DataMember]
        public int ReflexMiscModifier { get; set; }
        [DataMember]
        public int WillTotal { get; set; }
        [DataMember]
        public int WillBaseSave { get; set; }
        [DataMember]
        public int WillAbilityModifier { get; set; }
        [DataMember]
        public int WillMiscModifier { get; set; }
        [DataMember]
        public int MeleeTotal { get; set; }
        [DataMember]
        public int MeleeBase { get; set; }
        [DataMember]
        public int MeleeStrengthModifier { get; set; }
        [DataMember]
        public int MeleeSizeModifier { get; set; }
        [DataMember]
        public int MeleeMiscModifier { get; set; }
        [DataMember]
        public int RangeTotal { get; set; }
        [DataMember]
        public int RangeBase { get; set; }
        [DataMember]
        public int RangeDexterityModifier { get; set; }
        [DataMember]
        public int RangeSizeModifier { get; set; }
        [DataMember]
        public int RangeMiscModifier { get; set; }
    }
}
