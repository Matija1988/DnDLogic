using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Utilities
{
    internal class ErrorMessages
    {
        public static void ErrorMessageInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            GraphicElements.PrintChars("WRONG INPUT!!!", '!');
            Console.ResetColor();
        }
    }
}
