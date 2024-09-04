using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public sealed class Strength : AbstAttribute
    {
        public string Name { get; init; } = "Strength";
       
        public Strength(int value)
        {
            Value = value;
            Modifier = CalculateModifier(value);
            Description = new StringBuilder();
            Description.Append("Strength measures a characters ability to exert physical force. " +
            "A character with high Strength can lift heavier objects, carry more gear without being overloaded," +
            " break things with brute force, shove and grapple creatures more effectively, and is more accurate and " +
            "more effective with melee weapons.\r\n\r\nThis is most important for characters who fight in melee using heavy" +
            " weapons like longswords and greataxes. Barbarians, Fighters, and Paladins frequently have high Strength.");
        }

       

        public override string ToString ()
        {
            return $"ATTRIBUTE: {Name} \nVALUE: {Value}\nMODIFIER: {Modifier} \n";
        }
    }
}
