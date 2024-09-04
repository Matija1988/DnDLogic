using DnDLogic.Models.Atributes;
using DnDLogic.Models.Enums;
using DnDLogic.Models.PlayableClasses;
using DnDLogic.Models.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Player
{
    public class CharBuilder : ICharacterBuilder
    {

        public PlayerChar player = new();

        public CharBuilder ()
        {

        }

     
        public void SetName (string name) => player.Name = name;
     


        public void SetClass (int choice)
        {
            int i = 0;

            foreach (var c in Enum.GetValues<ClassList>())
            {
                Console.WriteLine(++i + ") " + c.ToString());
            }


            player.PlayerClass = choice switch
            {
                1 => this.player.PlayerClass = new Fighter(),
                _ => throw new NotImplementedException(),
            };
        }

        public void SetRace(int choice)
        {
            int i = 0;

            foreach (var c in Enum.GetValues<RacesEnum>())
            {
                Console.WriteLine(++i + ") " + c.ToString());
            }

            this.player.AbstRace = choice switch
            {
                1 =>  new Human(),
                2 =>  new Dwarf(),
                _ => throw new ArgumentOutOfRangeException("Invalid race choice")
            };

        }

        public void SetStrength (int strength) => player.Attributes.Add(new Strength(strength));
       
        public void SetDexterity (int dexterity) => player.Attributes.Add(new Dexterity(dexterity)); 
       
        public void SetConstitution (int constitution) => player.Attributes.Add(new Constitution(constitution));
      
        public void SetIntelligence (int intelligence) => player.Attributes.Add(new Intelligence(intelligence));
      
        public void SetWisdom (int wisdom) => player.Attributes.Add(new Wisdom(wisdom));
       
        public void SetCharisma (int charisma) => player.Attributes.Add(new Charisma(charisma));
  
        public void SetGender (char gender) => player.Gender = gender;
      
        public void SetBio (string? bio) => player.Bio = bio;
      

    }
}
