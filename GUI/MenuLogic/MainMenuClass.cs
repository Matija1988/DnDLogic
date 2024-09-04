using DnDLogic.Menues;
using DnDLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.GUI.MenuLogic
{
    public class MainMenuClass
    {
      
        public MainMenuClass ()
        {
          // Console.SetWindowSize(1500, 1500);
            
        }

        public void MainMenuMethod ()
        {
            MainMenu.MainMenuText();

            int choice = UserInputs.InputIntZeroAllowed("ENTER CHOICE: ");

            MainMenuSwitch(choice);
        }

        private void MainMenuSwitch (int choice)
        {
            switch (choice)
            {
                case 0:
                    ExitGame();
                    break;
                case 1:
                    
                    StartNewGame();
                    break;
                default:
                    ErrorMessages.ErrorMessageInput();
                    break;

            }
        }

        private void ExitGame ()
        {
            Console.WriteLine("Run away you coward....");
            Environment.Exit(0);
        }

        private void StartNewGame ()
        {
            Console.Clear();
            CharacterCreationGUI ccGUI = new();
            ccGUI.CharacterCreation();
            
        }
    }
}
