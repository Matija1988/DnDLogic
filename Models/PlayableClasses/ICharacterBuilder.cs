using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.PlayableClasses
{
    public interface ICharacterBuilder
    {
        void SetName ();

        void SetDescription (string description);

        void SetGender (char gender);

        void SetStrength (int strength);

        void SetDexterity (int dexterity);

        void SetConstitution (int constitution);

        void SetIntelligence (int intelligence);

        void SetWisdom (int wisdom);

        void SetCharisma (int charisma);
    }
}
