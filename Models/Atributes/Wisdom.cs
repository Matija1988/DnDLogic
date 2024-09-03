using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public class Wisdom : AbstAttribute
    {
        public string Name { get; init; } = "Wisdom";

        public Wisdom (int value)
        {
            Value = value;
            Modifier = CalculateModifier(value);
            Description = new StringBuilder();
            Description.Append("Wisdom can overlap with Intelligence, but the main delineating factor is that Wisdom refers to practical knowledge, " +
                "something you’re more likely to learn by going out and doing things rather than simply reading about them.");

        }

        public override string ToString ()
        {
            return $"ATTRIBUTE: {Name} \nVALUE: {Value}\nMODIFIER: {Modifier} \n";
        }
    }
}
