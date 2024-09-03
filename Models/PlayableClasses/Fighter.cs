using DnDLogic.Models.Special;
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
        public string Description { get; set; }
        public char Gender { get; set; }
        public List<Ability> Abilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Fighter (string name, string description, char gender, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Description = description;
            Gender = gender;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public Fighter()
        {
            
        }

        public override string ToString ()
        {
            return $"Fighter: {Name} \nDescription: {Description} \nSTATS: Str {Strength} \nDEX {Dexterity}\nCON {Constitution}\nINT {Intelligence}\nWIS {Wisdom}\nCHR {Charisma}";
        }
    }
}
