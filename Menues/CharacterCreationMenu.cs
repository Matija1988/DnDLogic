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

            GraphicElements.PrintChars("CREATE CHARACTER", '*');
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1) Enter character name ");
            
        }
    }
}
