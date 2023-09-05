using System;
using System.Collections.Generic;

namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesNumber = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            
            for (int i = 0; i < heroesNumber; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string name = tokens[0];
                int hp = int.Parse(tokens[1]);
                int mp = int.Parse(tokens[2]);

                if (!heroes.ContainsKey(name))
                {
                    heroes.Add(name, new Hero());
                }

                heroes[name].Name = name;
                heroes[name].HP = hp;
                heroes[name].MP = mp;

            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" - ");
                string heroName = arguments[1];
                switch (arguments[0]) 
                {
                    case "CastSpell":
                        int manaPoints = int.Parse(arguments[2]);
                        string spell = arguments[3];

                        if (heroes[heroName].MP >= manaPoints)
                        {
                            heroes[heroName].MP -= manaPoints;
                            Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName].MP} MP!");
                        }
                        else 
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(arguments[2]);
                        string attacker = arguments[3];

                        if (heroes[heroName].HP > damage)
                        {
                            heroes[heroName].HP -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroes.Remove(heroName);
                        }
                        break;

                    case "Recharge":
                        int amountMP = int.Parse(arguments[2]);                        
                        int mp = heroes[heroName].MP;

                        heroes[heroName].MP += amountMP;
                        if (heroes[heroName].MP > 200)
                        {
                            amountMP = 200 - mp;
                            heroes[heroName].MP = 200;
                        }
                        Console.WriteLine($"{heroName} recharged for {amountMP} MP!");                        
                        break;

                    case "Heal":
                        int amountHP = int.Parse(arguments[2]);
                        int hp = heroes[heroName].HP;

                        heroes[heroName].HP += amountHP;
                        if (heroes[heroName].HP > 100)
                        {
                            amountHP = 100 - hp;
                            heroes[heroName].HP = 100;
                        }
                        Console.WriteLine($"{heroName} healed for {amountHP} HP!");
                        break;
                }
            }
            foreach (Hero hero in heroes.Values) 
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }
        }

        public class Hero
        {           
            public string Name { get; set; }
            public int HP { get; set; }
            public int MP { get; set; }
        }
    }
}
