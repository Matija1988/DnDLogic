﻿using DnDLogic.Models.PlayableClasses;
using DnDLogic.Models.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Player
{
    public interface ICharacterBuilder
    {
        void SetName(string name);

        void SetBio (string? bio);

        void SetClass (int choice);

        void SetRace(int choice);

        void SetGender(char gender);

        void SetStrength(int strength);

        void SetDexterity(int dexterity);

        void SetConstitution(int constitution);

        void SetIntelligence(int intelligence);

        void SetWisdom(int wisdom);

        void SetCharisma(int charisma);
    }
}
