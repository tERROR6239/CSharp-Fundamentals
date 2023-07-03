using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] argguments = commands.Split(' ');                    

                if (argguments[0] == "Add")
                {
                    int newWagon = int.Parse(argguments[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengers = int.Parse(argguments[0]);
                        if (wagons[i] + passengers <= wagonCapacity)
                        {
                            int newWagonCapacity = wagons[i] + passengers;
                            wagons.RemoveAt(i);
                            wagons.Insert(i, newWagonCapacity);
                            break;
                        }                        
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
