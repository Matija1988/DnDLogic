using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public class FighterBuilder : ICharacterBuilder
    {
        private Fighter _fighter = new Fighter();

        public FighterBuilder()
        {
            SetName();
        }

        public void SetCharisma (int charisma)
        {
            this._fighter.Charisma = charisma;
        }

        public void SetConstitution (int constitution)
        {
           this._fighter.Constitution = constitution;
        }

        public void SetDescription (string description)
        {
          this._fighter.Description = description;
        }

        public void SetDexterity (int dexterity)
        {
            this._fighter.Dexterity = dexterity;
        }

        public void SetGender (char gender)
        {
           this._fighter.Gender = gender;
        }

        public void SetIntelligence (int intelligence)
        {
           this._fighter.Intelligence = intelligence;
        }

        public void SetName ()
        {
            string name = Console.ReadLine();
           this.SetName(name);
        }

        public void SetStrength (int strength)
        {
            this._fighter.Strength = strength;
        }

        public void SetWisdom (int wisdom)
        {
            this._fighter.Wisdom = wisdom;
        }
    }
}
