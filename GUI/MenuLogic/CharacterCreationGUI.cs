using DnDLogic.Menues;
using DnDLogic.Models.Enums;
using DnDLogic.Models.Player;
using DnDLogic.Models.Races.RaceSpecial;
using DnDLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.GUI.MenuLogic
{
    public class CharacterCreationGUI
    {
        public CharacterCreationGUI()
        {
            
        }

        public void CharacterCreation ()
        {
            CharacterCreationMenu.CharacterCreationMainMenu();

            CharBuilder charBuilder1 = new CharBuilder();
          
            Console.SetCursorPosition(0, 5);
            charBuilder1.SetName(UserInputs.InputString("Enter character name:"));
            SetRace(charBuilder1);
            SetAttributes(charBuilder1);
        }

        private void SetRace (CharBuilder charBuilder1)
        {
            Console.WriteLine("Available races");

            RaceList raceList = new RaceList();

            int i = 0;
            int j = 0;
            foreach(var c in raceList.Races)
            {
                Console.WriteLine(++i + ") " + c.Name + "\n" + c.Description);

                foreach (var ability in c.RaceAbilities)
                {
                    Console.WriteLine(++j + ") " + ability.Name + "\n" + ability.Description);
                }
            }

            charBuilder1.SetRace(UserInputs.InputInt("Choose your race: "));
        }

        private void SetAttributes (CharBuilder charBuilder1)
        {
           
        }
    }
}
