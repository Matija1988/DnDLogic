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
        string Name { get; }
        string Description { get; }

        List<RaceAbility> RaceAbilities { get; }
    }
}
