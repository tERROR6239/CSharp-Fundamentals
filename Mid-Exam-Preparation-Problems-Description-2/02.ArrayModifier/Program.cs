using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int index1, index2;

                switch (arguments[0])
                {
                    case "swap":
                        index1 = int.Parse(arguments[1]);
                        index2 = int.Parse(arguments[2]);

                        int swap = list[index1];
                        list[index1] = list[index2];
                        list[index2] = swap;

                        break;

                    case "multiply":
                        index1 = int.Parse(arguments[1]);
                        index2 = int.Parse(arguments[2]);

                        list[index1] = list[index1] * list[index2];
                        break;

                    case "decrease":
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i]--;
                        }
                        break;                    
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
