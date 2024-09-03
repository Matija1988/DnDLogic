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
            Description.Append("");
           
           
        }

        public override string ToString ()
        {
            return $"Fighter: {Name} \nDescription: {Description} \n";
        }
    }
}
