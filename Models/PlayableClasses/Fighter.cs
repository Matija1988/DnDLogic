using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public class Fighter : IPlayableClass
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }


        public Fighter(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public override string ToString ()
        {
            return $"Fighter: {Name}, STATS: Str {Strength}, DEX {Dexterity}, CON {Constitution}, INT {Intelligence}, WIS {Wisdom}, CHR {Charisma}";
        }
    }
}
