using DnDLogic.Models.Races.RaceSpecial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races
{
    public class Dwarf : IRace
    {
        public string Name {  get; set; }

        public string Description {  get; set; }

        public List<RaceAbility> RaceAbilities { get; set; }
    }
}
