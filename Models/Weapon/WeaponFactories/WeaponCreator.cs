using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDLogic.Models.Weapon.Enums;

namespace DnDLogic.Models.Weapon.WeaponFactories
{
    public abstract class WeaponCreator
    {
        public abstract IWeapon CreateWeapon(string name, string damageDice, DamageTypes damageType);


    }
}
