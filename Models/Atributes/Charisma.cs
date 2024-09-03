using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public class Charisma : AbstAttribute
    {
        public string Name { get; init; } = "Charisma";

        public Charisma (int value)
        {
            Value = value;
            Modifier = CalculateModifier(value);
            Description = new StringBuilder();
            Description.Append("Charisma is the measure of the character's combined physical attractiveness, persuasiveness, and personal magnetism;" +
                " a high charisma score indicates superiority in all these attributes. A generally non-beautiful character can have a very high charisma " +
                "due to strong measures of the other two aspects of charisma. Charisma influences how many spells spontaneous arcane spell-casters (such as sorcerers and bards) " +
                "can cast per day, and the effectiveness of said spells.");

        }

        public override string ToString ()
        {
            return $"ATTRIBUTE: {Name} \nVALUE: {Value}\nMODIFIER: {Modifier} \n";
        }
    }
}
