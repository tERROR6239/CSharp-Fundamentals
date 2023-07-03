using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] arguments = command.Split(" ");
                int index;

                switch (arguments[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(arguments[1]));
                        break;

                    case "Remove":
                        if (numbers.Contains(int.Parse(arguments[1])))
                        {
                            numbers.Remove(int.Parse(arguments[1]));                            
                        }
                        break;

                    case "Replace":
                        index = numbers.IndexOf(int.Parse(arguments[1]));
                        if (numbers.Contains(int.Parse(arguments[1])))
                        {
                            numbers.Remove(int.Parse(arguments[1]));
                            numbers.Insert(index, int.Parse(arguments[2]));
                        }
                        break;

                    case "Collapse": 
                        
                        int numbersCount = numbers.Count;
                        int k = 0;
                        for (int i = 0; i < numbersCount; i++)
                        {
                            if (numbers[k] < int.Parse(arguments[1]))
                            {                                
                                numbers.RemoveAt(k);
                            }
                            else
                            {
                                k++;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }    
}
