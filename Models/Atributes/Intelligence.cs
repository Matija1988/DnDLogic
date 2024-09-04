using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public sealed class Intelligence : AbstAttribute
    {
        public string Name { get; init; } = "Intelligence";

        public Intelligence (int value)
        {
            Value = value;
            Modifier = CalculateModifier(value);
            Description = new StringBuilder();
            Description.Append("Intelligence is, simply, book smarts. \n" +
                "If it involves something you learn by sitting in a library for long amounts of time and reading books, it will use Intelligence.");

        }

        public override string ToString ()
        {
            return $"ATTRIBUTE: {Name} \nVALUE: {Value}\nMODIFIER: {Modifier} \n";
        }
    }
}
