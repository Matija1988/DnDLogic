using DnDLogic.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Utilities
{
    public static class BasicValidations
    {
        internal static bool IntLessThanZero (Predicate<int> intLessThanZero, int extraPoints)
        {
            if (intLessThanZero(extraPoints))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"YOU'VE SPENT MORE POINTS THEN ALLOWED: {extraPoints}");
                Console.ResetColor();
                return true; 
            }
            return false;
        }
    }
}
