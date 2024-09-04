using DnDLogic.Models.Races.RaceSpecial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races
{
    public class Human : AbstRace
    {
       
        public Human()
        {
            Name = new StringBuilder();
            Name.Append("Human");
            Size = "Medium";
            BaseSpeed = 30;
            Description = new StringBuilder();
            Description.Append("Humans are the most adaptable and ambitious people among the common races. \n" +
                "They have widely varying tastes, morals, and customs in the many different lands where they have settled. \n" +
                "When they settle, though, they stay: they build cities to last for the ages, and great kingdoms that can persist for long centuries. \n" +
                "An individual human might have a relatively short life span, but a human nation or culture preserves traditions with origins far beyond\n" +
                " the reach of any single human’s memory. They live fully in the present—making them well suited to the adventuring life—but also plan for \n" +
                "the future, striving to leave a lasting legacy. Individually and as a group, humans are adaptable opportunists, and they stay alert to \n" +
                "changing political and social dynamics.");
            RaceAbilities = new List<RaceAbility>();
            RaceAbilities =
            [
                new RaceAbility("ABILITY SCORE INCREASE", "Increase two different attributes of your choice by 1", 1),
                new RaceAbility("SKILLS","You gain proficiency in one skill of your choice.", 1),
                new RaceAbility("FEAT","You gain one feat of your choice.", 1)
            ];

        }
    }
}
