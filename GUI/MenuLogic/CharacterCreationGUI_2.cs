using DnDLogic.Models.Atributes;
using DnDLogic.Models.Player;
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

        private void SetAttributes (CharBuilder charBuilder1)
        {
            int extraPoints = 20;
            Predicate<int> intLessThanZero = (x) => x < 0;

            Console.WriteLine("You have 20 extra points to allocate to attributes. Caution - The modifier affect the cost.\n" +
                "INITAL VALUE OF ALL ATTRIBUTES IS 10");

            extraPoints = SetStrenght(extraPoints, charBuilder1);

            if(intLessThanZero(extraPoints)) 
            {
                Console.WriteLine($"YOU'VE SPENT MORE POINTS THEN ALLOWED: {extraPoints}");
            }

            Console.WriteLine($"STRENGTH: {charBuilder1._player.Attributes.Find(x => x is Strength)}");

            Console.WriteLine($"Extra points left {extraPoints}");


        }

        private int SetStrenght (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("STRENGTH: ");

            

            if (input > 20)
            {
                Console.WriteLine($"Cannot allocate more then {extraPoints} points to attributes!");
                SetStrenght(extraPoints, charBuilder1);
            }

            charBuilder1.SetStrength(input);

            var strAttr = charBuilder1._player.Attributes.Find(x => x is Strength);

            int modifierCost = strAttr.Modifier;

            if (modifierCost < 0)
            {
                return extraPoints + 10 - input + modifierCost;
            }

            return extraPoints + 10 - input - modifierCost;
        }
    }
}
