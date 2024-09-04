using DnDLogic.Models.Races.RaceSpecial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models.Races
{
    public class Dwarf : AbstRace
    {
    
        public Dwarf ()
        {
            Name = new StringBuilder();
            Name.Append("Dwarf");
            Size = "Medium";
            BaseSpeed = 20;
            Description = new StringBuilder();
            Description.Append("Dwarves favor earth tones in their clothing and prefer simple and functional garb. \n" +
                "The skin can be very dark, but it is always some shade of tan or brown. Hair color can be black, gray, or brown. \n" +
                "Dwarves average 4 feet tall and weigh as much as adult humans.");
            RaceAbilities = new List<RaceAbility> { 
            
                new RaceAbility("ABILITY SCORE INCREASE", "Your Constitution score increases by 2.", 2),
                new RaceAbility("DARKVISION","Accustomed to life underground, you have superior vision in dark and dim conditions.\n" +
                "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.\n" +
                "You can’t discern color in darkness, only shades of gray..", 1),
                new RaceAbility("DWARVEN RESILIENCE", "You have advantage on saving throws against poison, and you have resistance against poison damage (you take half poison damage).", 2)
            };



        }
    }
}
