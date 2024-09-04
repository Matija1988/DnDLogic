using DnDLogic.Models.Atributes;
using DnDLogic.Models.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public class Fighter : AbstPlayableClass
    {
        public string Name { get; set; } = "Fighter";
      
        public StringBuilder Description { get; set; }
      
        public List<Ability> Abilities { get; set; }

        public Fighter ()
        { 
            Description = new StringBuilder();
            Description.Append("Fighters share an unparalleled mastery with weapons and armor, and a " +
                "thorough knowledge of the skills of combat.\nThey are well acquainted with death, both meting " +
                "it out and staring it defiantly in the face.");
           
        }

        public override string ToString ()
        {
            return $"CLASS: {Name} \nDESCRIPTION: {Description} \n";
        }
    }
}
