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

        //will likely become object instead of string
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public int Strength { get; set; }
        [DataMember]
        public int Dexterity { get; set; }
        [DataMember]
        public int Constitution { get; set; }
        [DataMember]
        public int Intelligence { get; set; }
        [DataMember]
        public int Wisdom { get; set; }
        [DataMember]
        public int Charisma { get; set; }
    }
}
