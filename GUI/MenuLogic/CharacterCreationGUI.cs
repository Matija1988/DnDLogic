using DnDLogic.Menues;
using DnDLogic.Models.Enums;
using DnDLogic.Models.PlayableClasses;
using DnDLogic.Models.Player;
using DnDLogic.Models.Races;
using DnDLogic.Models.Races.RaceSpecial;
using DnDLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.GUI.MenuLogic
{
    public partial class CharacterCreationGUI
    {
        public CharacterCreationGUI ()
        {

        }

        public void CharacterCreation ()
        {
            CharacterCreationMenu.CharacterCreationMainMenu();

            CharBuilder charBuilder1 = new CharBuilder();

            Console.SetCursorPosition(0, 5);
            charBuilder1.SetName(UserInputs.InputString("Enter character name:"));
            SetGender(charBuilder1); 
            SetRace(charBuilder1);
            SetClass(charBuilder1);
            SetAttributes(charBuilder1);
          
        }

        private void SetGender (CharBuilder charBuilder1)
        {

            int genderChoice = UserInputs.InputInt("GENDER: 1) MAN 2) WOMAN ");

            char gender = genderChoice switch
            {
                1 => 'M',
                2 => 'W',
                _ => throw new ArgumentException("Invalid gender choice")
            };

            charBuilder1.SetGender(gender);
        }

        private void SetClass (CharBuilder charBuilder1)
        {
            Console.WriteLine("Available classes");

            ClassesList classesList = new ClassesList();

            int i = 0;

            foreach (var c in  classesList.PlayableClasses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(++i + ") " + c.ToString());
                Console.ResetColor();
                Console.WriteLine();
            }

            charBuilder1.SetClass(UserInputs.InputInt("Choose your class: "));
        }

        private void SetRace (CharBuilder charBuilder1)
        {
            Console.WriteLine("Available races");

            RaceList raceList = new RaceList();

            int i = 0;
           
            foreach (var c in raceList.Races)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(++i + ") " + c.Name + "\n" + c.Description);
                Console.ResetColor();

                RaceAbiltiyLoop(c);
                
                Console.WriteLine();

            }

            charBuilder1.SetRace(UserInputs.InputInt("Choose your race: "));
        }

        private void RaceAbiltiyLoop (AbstRace race)
        {
            

            if (race.RaceAbilities is not null)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("RACE ABILITIES" );
                foreach (var ability in race.RaceAbilities)
                {
                   
                    Console.WriteLine("+) " + ability.Name + "\n" + ability.Description);
                    
                }
                Console.ResetColor();

            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Race has no abilities");
                Console.ResetColor();
            }


        }

    }
}
