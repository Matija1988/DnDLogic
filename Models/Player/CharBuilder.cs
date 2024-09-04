using DnDLogic.Models.Enums;
using DnDLogic.Models.PlayableClasses;
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
           this.player.Name = name;
        }


        public void setClass (int choice)
        {
            int i = 0;

           // foreach(var c in Enum.GetValues<ClassList>())
           // {
           //     Console.WriteLine(i++ + ") " + c.ToString());
           // }
            

           //int c switch
           // {
           //     1 => new Fighter(),

           // } ;
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
