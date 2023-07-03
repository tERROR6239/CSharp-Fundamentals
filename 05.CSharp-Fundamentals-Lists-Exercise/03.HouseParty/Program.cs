using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestsNumber = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < guestsNumber; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ");

                if (arguments[2] != "not" && !guests.Contains(arguments[0]))
                {
                    guests.Add(arguments[0]);
                }
                else if (arguments[2] != "not" && guests.Contains(arguments[0]))
                {
                    Console.WriteLine($"{arguments[0]} is already in the list!");
                }
                else if (arguments[2] == "not" && guests.Contains(arguments[0]))
                {
                    guests.Remove(arguments[0]);
                }
                else if (arguments[2] == "not" && !guests.Contains(arguments[0]))
                {
                    Console.WriteLine($"{arguments[0]} is not in the list!");
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
