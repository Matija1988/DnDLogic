using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDLogic.Models.Enums;

namespace DnDLogic.Models.Weapon.Melee
{
    public class Sword : IWeapon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string DamageDice { get; set; }
        public Enum DamageType { get; set; }

        public Sword(Guid id, string name, string damageDice, DamageTypes damageType)
        {
            Id = id;
            Name = name;   
            DamageDice = damageDice;
            DamageType = damageType;
        }

        public override string ToString ()
        {
            return $"Sword: {Name}, Damage dice: {DamageDice}, Damage type: {DamageType}";
        }
    }
}
