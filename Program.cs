﻿// See https://aka.ms/new-console-template for more information

using DnDLogic.GUI.MenuLogic;
using DnDLogic.Menues;
using DnDLogic.Models;
using DnDLogic.Models.Atributes;
using DnDLogic.Models.Enums;
using DnDLogic.Models.Player;
using DnDLogic.Models.Weapon;
using DnDLogic.Models.Weapon.Melee;
using DnDLogic.Models.Weapon.WeaponFactories;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Xml;



MainMenuClass mainMenuClass = new MainMenuClass();
mainMenuClass.MainMenuMethod();

Random rand = new Random();

Strength str = new Strength(15);
Dexterity dex = new Dexterity(17);
Constitution constitution = new Constitution(12);
Intelligence intel = new Intelligence(8);
Wisdom wis = new Wisdom(5);
Charisma chr  = new Charisma(7);


CharBuilder charBuilder = new CharBuilder();
charBuilder.SetClass(1);
charBuilder.SetName("SirDrinkAlot");
charBuilder.SetRace(1);

var selectedRace = charBuilder._player.AbstRace.RaceAbilities.Find(x => x.Name.Equals("ABILITY SCORE INCREASE"));

charBuilder.SetStrength(18 + selectedRace.Modifier);
charBuilder.SetDexterity(12); 
charBuilder.SetConstitution(16);
charBuilder.SetIntelligence(10);
charBuilder.SetWisdom(8);
charBuilder.SetCharisma(8);
charBuilder.SetGender('M');
charBuilder.SetBio("Big, strong and not very bright!");


Console.WriteLine($"{charBuilder._player.Name} " +
    $"\nGENDER: {charBuilder._player.Gender} " +
    $"\nBIO: {charBuilder._player.Bio} " +
    $"\n{charBuilder._player.PlayerClass} " +
    $"\nRACE: {charBuilder._player.AbstRace.Name}");

foreach (var attribute in charBuilder._player.Attributes)
{
    Console.Write(attribute.ToString());
}

var raceAbilities = charBuilder._player.AbstRace.RaceAbilities;

Console.WriteLine("Race abilities count " + raceAbilities);

foreach(var c in raceAbilities)
{
    Console.WriteLine(c.Name + "\n" + c.Description);
}

WeaponCreator swordSmith = new SwordFactory();
WeaponCreator maceSmith  = new MaceFactory();

IWeapon longsword = swordSmith.CreateWeapon("Greatsword", "2d8", DamageTypes.Slashing);
IWeapon goblinMace = maceSmith.CreateWeapon("Goblin mace", "1d6", DamageTypes.Bludgeoning);

Knight sirDrinkAlot = new Knight{Name= "SirDrinkAlot", Weapon = (Sword)longsword };
Goblin goblin = new Goblin { Hp = 10, ArmorRating = 8, Weapon = (Mace)goblinMace, Name = "Goblin" };


string[] separator = longsword.DamageDice.Split('d');

int numberOfRolls = int.Parse(separator[0]);
int maxDamagePerRoll = int.Parse(separator[1]);

int d20 = rand.Next(0, 19);


int armorRating = goblin.ArmorRating;
int health = goblin.Hp;

Dictionary <Func<int, bool>, Func<int, string>> rules = new Dictionary<Func<int, bool>, Func<int, string>>();
rules.Add(x => x == 19, x => CriticalHit(d20));
rules.Add(x => x == 0, x => CriticalMiss(d20));
rules.Add(x => x > armorRating, x => Hit(d20));
rules.Add(x => x <= armorRating, x =>  Miss(d20));

var result = rules.Where(x => x.Key(d20)).Select(x => x.Value(d20));

Console.WriteLine(result.ToList().FirstOrDefault());

string CriticalHit(int x)
{
    int damage = CalculateDamage(maxDamagePerRoll, numberOfRolls);
    damage *= 2;
    health -= damage;

    if (health < 0) 
    {
        return $"Critical hit! You roled {x + 1} and hit the enemy for {damage} {sirDrinkAlot.Weapon.DamageType} damage! Goblin is killed in one blow!";
    }

    return $"Critical hit! You roled {x+1} and hit the enemy for {damage} {sirDrinkAlot.Weapon.DamageType} damage! Goblin is left with {health} hp";
}

string CriticalMiss(int x)
{
    return $"Critical miss! You roled {x + 1}";
}
string Hit(int x)
{
    int damage = CalculateDamage(maxDamagePerRoll, numberOfRolls);
    health -= damage;
    
    if (health < 0)
    {
        return $"Staggering hit! You roled {x + 1} and hit the enemy for {damage} {sirDrinkAlot.Weapon.DamageType} damage! Goblin is killed in one blow!";
    }

    return $"Hit! You roled {x+1} and hit the enemy for {damage} {sirDrinkAlot.Weapon.DamageType} damage! Goblin is left with {health} hp";
}

string Miss(int x)
{
    return $"Miss! You roled {x + 1}";
}

int CalculateDamage(int maxDamageRange, int numberOfRolls)
{
    int hit = 1;
    int[] hits = new int[numberOfRolls]; 

    Random r = new Random();
    
    for(int i = 0; i < numberOfRolls; i++)
    {
        hit =+ r.Next(1, maxDamageRange);
        hits[i] = hit;
        Console.WriteLine(hit);
    }

    return hits.Sum();
}
