using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Utilities
{
    public class GraphicElements
    {
        public static void PrintChars (string message, char charToPrint)
        {
            int messageLenght = message.Length;
            int width = 80 /2;

           
            for (int i = 0; i < (width - messageLenght - 1); i++)
            {
                Console.Write(charToPrint);
            }
            Console.Write(" " + message + " ");
            for (int i = 0; i < (width - messageLenght - 1); i++)
            {
                Console.Write(charToPrint);
            }
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}
