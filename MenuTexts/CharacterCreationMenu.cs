using DnDLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Menues
{
    public static class CharacterCreationMenu
    {
        public static void CharacterCreationMainMenu ()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            GraphicElements.DrawBox(0, 0, 80, 5);
            Console.SetCursorPosition(4, 2);
            GraphicElements.PrintChars("CREATE CHARACTER", '*');
            Console.ResetColor();
            Console.WriteLine();
          
            
        }

        public static void ClassChoiceMenu()
        {

        }
    }
}
