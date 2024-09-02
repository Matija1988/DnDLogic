using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDLogic.Models.Weapon;
using DnDLogic.Models.Weapon.Melee;

namespace DnDLogic.Models
{
    public class Goblin
    {
        public int Hp {  get; set; }

        public IWeapon Weapon { get; set; }

        public string Name { get; set; }

        public int ArmorRating { get; set; }
    }
}
