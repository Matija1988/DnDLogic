using DnDLogic.Models.Races.RaceSpecial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races
{
    public interface IRace
    {
        public  StringBuilder Name { get; init; }
        public StringBuilder Description { get; init; }

        public string Size { get; init; }

        public int BaseSpeed { get; init; }

        public List<RaceAbility> RaceAbilities { get; init; }
    }
}
