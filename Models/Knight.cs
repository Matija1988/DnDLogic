using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDLogic.Models.Weapon;
using DnDLogic.Models.Weapon.Melee;

namespace DnDLogic.Models
{
    public class Knight
    {
        public string Name { get; set; }
        public IWeapon Weapon { get; set; }

    }
}
