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

        public PlayerChar _player = new();

        public CharBuilder ()
        {

        }

     
        public void SetName (string name) => _player.Name = name;
     


        public void SetClass (int choice)
        {
            int i = 0;

            foreach (var c in Enum.GetValues<ClassList>())
            {
                Console.WriteLine(++i + ") " + c.ToString());
            }


            _player.PlayerClass = choice switch
            {
                1 => this._player.PlayerClass = new Fighter(),
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

            this._player.AbstRace = choice switch
            {
                1 =>  new Human(),
                2 =>  new Dwarf(),
                _ => throw new ArgumentOutOfRangeException("Invalid race choice")
            };

        }

        public void SetStrength (int strength) => _player.Attributes.Add(new Strength(strength));

        public void SetStrenght (int strenght, int racialModifier) => _player.Attributes.Add(new Strength(strenght +  racialModifier));
       
        public void SetDexterity (int dexterity) => _player.Attributes.Add(new Dexterity(dexterity));

        public void SetDexterity (int dexterity, int racialModifier) => _player.Attributes.Add(new Dexterity(dexterity + racialModifier));

        public void SetConstitution (int constitution) => _player.Attributes.Add(new Constitution(constitution));

        public void SetConstitution (int constitution, int racialModifier) => _player.Attributes.Add(new Constitution(constitution + racialModifier));

        public void SetIntelligence (int intelligence) => _player.Attributes.Add(new Intelligence(intelligence));

        public void SetIntelligence (int intelligence, int racialModifier) => _player.Attributes.Add(new Intelligence(intelligence + racialModifier));

        public void SetWisdom (int wisdom) => _player.Attributes.Add(new Wisdom(wisdom));

        public void SetWisdom (int wisdom, int racialModifier) => _player.Attributes.Add(new Wisdom(wisdom + racialModifier));

        public void SetCharisma (int charisma) => _player.Attributes.Add(new Charisma(charisma));

        public void SetCharisma (int charisma, int racialModifier) => _player.Attributes.Add(new Charisma(charisma + racialModifier));

        public void SetGender (char gender) => _player.Gender = gender;
      
        public void SetBio (string? bio) => _player.Bio = bio;
      

    }
}
