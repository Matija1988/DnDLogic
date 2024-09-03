using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public abstract class AbstAttribute : IAttribute
    {
        public virtual string Name { get; init; }
        public virtual int Value { get ; set; }
        public StringBuilder Description { get ; init ; }
        public int Modifier { get ; set; }

        public int CalculateModifier (int value)
        {
            return value switch
            {
                1 => -5,
                2 or 3 => -4,
                4 or 5 => -3,
                6 or 7 => -2,
                8 or 9 => -1,
                10 or 11 => 0,
                12 or 13 => 1,
                14 or 15 => 2,
                15 or 16 => 3,
                17 or 18 => 4,
                19 or 20 => 5,
                21 or 22 => 6,
                23 or 24 => 7,
                25 or 26 => 8,
                27 or 28 => 9,
                29 or 30 or > 30 => 10,
                _ => throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 1 and 30")
            };
        }

    }
}
