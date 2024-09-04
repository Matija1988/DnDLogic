using DnDLogic.Models.Races;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public class ClassesList
    {
        public ImmutableList<AbstPlayableClass> PlayableClasses { get; }
        public ClassesList ()
        {
            PlayableClasses = [new Fighter()];
        }
    }
}
