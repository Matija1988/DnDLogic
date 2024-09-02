using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Weapon
{
    public interface IWeapon : IItem
    {
        public Enum DamageType { get; set;  }

        public string DamageDice { get; set; }
    }
}
