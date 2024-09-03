using DnDLogic.Models.Atributes;
using DnDLogic.Models.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public class AbstPlayableClass : IPlayableClass
    {
        public string Name { get; set; }
        public StringBuilder Description { get; set; }
       
        public List<Ability>? Abilities { get; set; }
    }
}
