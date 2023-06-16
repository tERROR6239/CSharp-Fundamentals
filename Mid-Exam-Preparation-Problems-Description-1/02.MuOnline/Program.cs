using System;
using System.Linq;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;                                                       //del

            string[] dungeonRooms = Console.ReadLine().Split('|').ToArray();
            int cuurentRoom = 0;

            foreach (string room in dungeonRooms)                                   // for(int i = 0; i <dungeonRooms.Length; i++)
            {
                cuurentRoom++;                                                      //del
                string[] roomTokens = room.Split(" ").ToArray();                    // = dungeonRooms[i].Split(" ").ToArray();

                string commandOrMonster = roomTokens[0];
                int amount = int.Parse(roomTokens[1]);

                if (commandOrMonster == "potion")
                {
                    if (health + amount > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else 
                    {
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                    continue;
                }
                if (commandOrMonster == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                    continue;
                }

                health -= amount;

                if (health <= 0)
                {
                    Console.WriteLine($"You died! Killed by {commandOrMonster}.");
                    Console.WriteLine($"Best room: {cuurentRoom}");                             //{i + 1}
                    return;
                }

                Console.WriteLine($"You slayed {commandOrMonster}.");
            }
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");                
        }
    }
}
