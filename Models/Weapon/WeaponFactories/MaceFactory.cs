using DnDLogic.Models.Weapon.Enums;
using DnDLogic.Models.Weapon.Melee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Weapon.WeaponFactories
{
    public class MaceFactory : WeaponCreator
    {
        public MaceFactory()
        {

        }

        public override IWeapon CreateWeapon(string name, string damageDice, DamageTypes damageType)
        {
            Guid id = Guid.NewGuid();
            return new Mace(id, name, damageDice, damageType);
        }
    }
}
