using DnDLogic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.GUI.MenuLogic
{
    public partial class CharacterCreationGUI
    {
        private void AllocateRemainingPoints (int extraPoints)
        {
            if (extraPoints > 0)
            {
                Console.WriteLine($"You have {extraPoints} points remaining to allocate");
                int i = 0;

                foreach(var c in Enum.GetValues<AttributesEnum>())
                {
                    Console.WriteLine(++i + ") " + c);
                }
            }
        }
    }
}
