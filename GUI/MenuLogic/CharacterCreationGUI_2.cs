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

            Console.WriteLine("You have 20 extra points to allocate to attributes. Caution - The modifier affect the cost.\n" +
                "INITAL VALUE OF ALL ATTRIBUTES IS 10");

            SetStrenght(extraPoints, charBuilder1);

            Console.WriteLine($"STRENGTH: {charBuilder1.player.Attributes.Find(x => x.Name.Equals("Strenght", StringComparison.OrdinalIgnoreCase)).Modifier}");


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
            int modifierCost =  charBuilder1.player.Attributes.Find(x => x.Name.Equals("Strenght", StringComparison.OrdinalIgnoreCase)).Modifier;
            
            return extraPoints + 10 - input - modifierCost;
        }
    }
}
