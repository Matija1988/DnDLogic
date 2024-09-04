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

        public static void DrawBox(int cursorX, int cursorY, int width, int height)
        {
            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("+" + new string('-', width - 2) + "+");

          
            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(cursorX, cursorY + i);
                Console.Write("|" + new string(' ', width - 2) + "|");
            }

           
            Console.SetCursorPosition(cursorX, cursorY + height - 1);
            Console.Write("+" + new string('-', width - 2) + "+");
        }
    }
}
