using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public sealed class Dexterity : AbstAttribute
    {
        public string Name { get; init; } = "Dexterity";
       
      

        public Dexterity(int value)
        {
            Value = value;
            Modifier = CalculateModifier(value);
            Description = new StringBuilder();
            Description.Append("Dexterity refers to how good your character is at moving and controlling their body," +
                " whether that be slipping their hand into someone’s pocket unnoticed, or skillfully knocking an arrow " +
                "into a bow. The classes that excel at Dexterity aren’t focused on raw power; they’re focused on being " +
                "very skilled.\r\n\r\nDex is a skill that everyone should invest in because it determines your Armor Class, " +
                "making you harder to hit the higher it is.");

        }

        public override string ToString ()
        {
            return $"ATTRIBUTE: {Name} \nVALUE: {Value}\nMODIFIER: {Modifier} \n";
        }
    }
}
