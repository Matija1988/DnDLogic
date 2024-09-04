using DnDLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Menues
{
    public static class MainMenu
    {
        public static void MainMenuText ()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            GraphicElements.PrintChars("MAIN MENU", '*');
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1) START NEW GAME");
            Console.WriteLine("0) EXIT");

        }

   
    }
}
