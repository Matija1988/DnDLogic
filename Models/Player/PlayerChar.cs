using DnDLogic.Models.Atributes;
using DnDLogic.Models.PlayableClasses;
using DnDLogic.Models.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Player
{
    public class PlayerChar
    {
        public string Name { get; set; }

        public string? Bio { get; set; }

        public char Gender { get; set; }

        public int Level { get; set; }

        public int Exp { get; set; }

        public AbstRace AbstRace { get; set; }

        public List<AbstAttribute>  Attributes { get; set; } 

        public AbstPlayableClass PlayerClass { get; set; }

        public PlayerChar()
        {
            Attributes = new List<AbstAttribute>();
            
        }
    }
}
