using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Atributes
{
    public interface IAttribute
    {
         string Name { get; init; }

         int Value { get; set; }

         StringBuilder Description { get; init; }

         int Modifier { get; set; }

        int CalculateModifier (int value);


    }
}
