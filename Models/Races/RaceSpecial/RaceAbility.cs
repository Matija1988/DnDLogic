using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races.RaceSpecial
{
    public class RaceAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Modifier { get; set; }

        public RaceAbility (string name, string description, int modifier)
        {
            Name = name;
            Description = description;
            Modifier = modifier;
        }
    }
}
