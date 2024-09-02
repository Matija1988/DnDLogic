using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Utilities
{
    public class UserInputs
    {
        public static string InputString (string input)
        {
            string s;

            while (true)
            {
                Console.Write (input);
                s = Console.ReadLine ();
                if(s.Trim().Length == 0) 
                {
                    ErrorMessages.ErrorMessageInput();
                    continue;
                }

                return s;

            }
        }

        public static int InputInt (string v)
        {
            while (true)
            {
                Console.Write(v);

                try
                {
                    int a = int.Parse(Console.ReadLine());

                    if (a == 0) { a++; } // This prevents entering 0 as a value when this method is called. Blokira unosenje nule kao vrijednosti u .npr izbornicima koji nemaju 0 kao opciju.
                                         // Ovo sluzi ako netko u odabiru indexa liste ne odabere 0 / - 1 i dobije array index out of bounds exception

                    if (a <= -1)
                    {
                        GraphicElements.PrintChars("INCORRECT INPUT!!!", '!');
                        continue;

                    }
                    if (a > 0) return a;
                }
                catch
                {
                    ErrorMessages.ErrorMessageInput();
                }

            }
        }

        public static int InputIntZeroAllowed (string v)
        {
            while (true)
            {
                Console.Write(v);

                try
                {
                    int a = int.Parse(Console.ReadLine());


                    if (a <= -1)
                    {
                        GraphicElements.PrintChars("INCORRECT INPUT!!!", '!');
                        continue;

                    }
                    if (a >= 0) return a;
                }
                catch
                {
                    ErrorMessages.ErrorMessageInput();
                }

            }
        }
    }
}
