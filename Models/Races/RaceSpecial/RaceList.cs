using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races.RaceSpecial
{
    public class RaceList
    {
        public ImmutableList<AbstRace> Races { get; set; }
        public RaceList()
        {
           Races = [new Human(), new Dwarf()];
        }

    }
}
