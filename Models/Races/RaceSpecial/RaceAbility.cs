using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races.RaceSpecial
{
    public class RaceAbility
    {
        public string Description { get; set; }

        public int Modifier { get; set; }

        public RaceAbility(string description, int modifier)
        {
            Description = description;
            Modifier = modifier;
        }
    }
}
