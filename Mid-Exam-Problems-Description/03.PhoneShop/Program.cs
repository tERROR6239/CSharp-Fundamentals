using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                List<string> arguments = command.Split(" - ").ToList();
                int index;

                switch (arguments[0])
                {
                    case "Add":
                        AddPhone(phones, arguments);
                        break;

                    case "Remove":
                        RemovePhone(phones, arguments);
                        break;

                    case "Bonus phone":
                        index = AddNewModel(phones, arguments);
                        break;

                    case "Last":
                        PhoneExists(phones, arguments);
                        break;
                }
            }

            
            Console.WriteLine(string.Join(", ", phones));
        }
        private static void AddPhone(List<string> phones, List<string> arguments)
        {
            if (!phones.Contains(arguments[1]))
            {
                phones.Add(arguments[1]);
            }
        }

        private static void RemovePhone(List<string> phones, List<string> arguments)
        {
            if (phones.Contains(arguments[1]))
            {
                phones.Remove(arguments[1]);
            }
        }

        private static int AddNewModel(List<string> phones, List<string> arguments)
        {
            int index;
            List<string> subArgument = arguments[1].Split(":").ToList();
            index = phones.IndexOf(subArgument[0]);
            if (phones.Contains(subArgument[0]))
            {
                phones.Insert(index + 1, subArgument[1]);
            }

            return index;
        }

        private static void PhoneExists(List<string> phones, List<string> arguments)
        {
            if (phones.Contains(arguments[1]))
            {
                phones.Remove(arguments[1]);
                phones.Add(arguments[1]);
            }
        }
    }
}
