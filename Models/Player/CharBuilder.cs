using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Player
{
    public class CharBuilder : ICharacterBuilder
    {

        private PlayerChar player = new();

        public CharBuilder()
        {
            
        }

        public void SetName (string name)
        {
           this.player.Name = string.Empty;
        }


        public void setClass (int choice)
        {
            throw new NotImplementedException();
        }

        public void SetStrength (int strength)
        {
            throw new NotImplementedException();
        }

        public void SetDexterity (int dexterity)
        {
            throw new NotImplementedException();
        }

        public void SetConstitution (int constitution)
        {
            throw new NotImplementedException();
        }

        public void SetIntelligence (int intelligence)
        {
            throw new NotImplementedException();
        }

        public void SetWisdom (int wisdom)
        {
            throw new NotImplementedException();
        }

        public void SetCharisma (int charisma)
        {
            throw new NotImplementedException();
        }
              
        public void SetGender (char gender)
        {
            throw new NotImplementedException();
        }

        public void setBio (string? bio)
        {
            throw new NotImplementedException();
        }

    }
}
