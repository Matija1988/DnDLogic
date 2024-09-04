using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public  sealed class Constitution : AbstAttribute
    {
        public string Name { get; init; } = "Constitution";
    
        public Constitution (int value)
        {
            Value = value;
            Modifier = CalculateModifier(value);
            Description = new StringBuilder();
            Description.Append("Constitution refers to general overall health and physical capability," +
                " whether that’s HP or how long you can do strenuous activity without taking a break." +
                " A penalty for failing a Constitution roll is frequently taking a level of exhaustion." +
                "\r\n\r\nWhile there are no associated skills with Constitution, you’ll frequently be making" +
                " Constitution checks to do things like, resist being poisoned, go long periods of time without sleep " +
                "(assuming you need it), or eat week-old leftovers without getting sick.");

        }

        public override string ToString ()
        {
            return $"ATTRIBUTE: {Name} \nVALUE: {Value}\nMODIFIER: {Modifier} \n";
        }
    }
}
