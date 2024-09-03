using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Special
{
    public class Ability
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string DeterminingStat { get; set; }

        public string SaveRollStat { get; set; }
    }
}
