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

            if(BasicValidations.IntLessThanZero(intLessThanZero, extraPoints)) 
            {  
                SetStrenght(extraPoints = 20, charBuilder1);
            }

            Console.WriteLine($"STRENGTH: {charBuilder1._player.Attributes.Find(x => x is Strength)}");

            Console.WriteLine($"Extra points left {extraPoints}");

            extraPoints = SetDexterity(extraPoints, charBuilder1);

            if(BasicValidations.IntLessThanZero(intLessThanZero, extraPoints))
            {
                SetDexterity(extraPoints = 20, charBuilder1);
            }

            Console.WriteLine($"DEXTERITY: {charBuilder1._player.Attributes.Find(x => x is Dexterity)}");

            Console.WriteLine($"Extra points left {extraPoints}");

            extraPoints = SetConstitution(extraPoints, charBuilder1);

            if (BasicValidations.IntLessThanZero(intLessThanZero, extraPoints))
            {
                SetConstitution(extraPoints, charBuilder1);
            }

            Console.WriteLine($"CONSTITUTION: {charBuilder1._player.Attributes.Find(x => x is Constitution)}");

            Console.WriteLine($"Extra points left {extraPoints}");

            extraPoints = SetIntelligence(extraPoints, charBuilder1);

            if (BasicValidations.IntLessThanZero(intLessThanZero, extraPoints))
            {
                SetIntelligence(extraPoints, charBuilder1);
            }

            Console.WriteLine($"INTELLIGENCE: {charBuilder1._player.Attributes.Find(x => x is Intelligence)}");

            Console.WriteLine($"Extra points left {extraPoints}");

            extraPoints = SetWisdom(extraPoints, charBuilder1);

            if (BasicValidations.IntLessThanZero(intLessThanZero, extraPoints))
            {
                SetWisdom(extraPoints, charBuilder1);
            }

            Console.WriteLine($"WISDOM: {charBuilder1._player.Attributes.Find(x => x is Wisdom)}");

            Console.WriteLine($"Extra points left {extraPoints}");

            extraPoints = SetCharisma(extraPoints, charBuilder1);

            if (BasicValidations.IntLessThanZero(intLessThanZero, extraPoints))
            {
                SetCharisma(extraPoints, charBuilder1);
            }

            Console.WriteLine($"CHARISMA: {charBuilder1._player.Attributes.Find(x => x is Charisma)}");

            Console.WriteLine($"Extra points left {extraPoints}");

        }

        private int SetCharisma (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("CHARISMA: ");

            charBuilder1.SetCharisma(input);

            var chrAttr = charBuilder1._player.Attributes.Find(x => x is Charisma);

            int modifierCost = chrAttr.Modifier;

            if (modifierCost < 0)
            {
                return extraPoints + 10 - input + modifierCost;
            }

            return extraPoints + 10 - input - modifierCost;
        }

        private int SetWisdom (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("WISDOM: ");

            charBuilder1.SetWisdom(input);

            var wisAttr = charBuilder1._player.Attributes.Find(x => x is Wisdom);

            int modifierCost = wisAttr.Modifier;

            if (modifierCost < 0)
            {
                return extraPoints + 10 - input + modifierCost;
            }

            return extraPoints + 10 - input - modifierCost;
        }

        private int SetIntelligence (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("INTELLIGENCE: ");

            charBuilder1.SetIntelligence(input);

            var intAttr = charBuilder1._player.Attributes.Find(x => x is Intelligence);

            int modifierCost = intAttr.Modifier;

            if (modifierCost < 0)
            {
                return extraPoints + 10 - input + modifierCost;
            }

            return extraPoints + 10 - input - modifierCost;
        }

        private int SetConstitution (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("CONSTITUTION: ");

            charBuilder1.SetConstitution(input);

            var conAttr = charBuilder1._player.Attributes.Find(x => x is Constitution);

            int modifierCost = conAttr.Modifier;

            if (modifierCost < 0)
            {
                return extraPoints + 10 - input + modifierCost;
            }

            return extraPoints + 10 - input - modifierCost;
        }

        private int SetDexterity (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("DEXTERITY: ");

            charBuilder1.SetDexterity(input);

            var dexAttr = charBuilder1._player.Attributes.Find(x => x is Dexterity);

            int modifierCost = dexAttr.Modifier;

            if (modifierCost < 0)
            {
                return extraPoints + 10 - input + modifierCost;
            }

            return extraPoints + 10 - input - modifierCost;
        }

        private int SetStrenght (int extraPoints, CharBuilder charBuilder1)
        {
            int input = UserInputs.InputInt("STRENGTH: ");

            if (input > extraPoints)
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
