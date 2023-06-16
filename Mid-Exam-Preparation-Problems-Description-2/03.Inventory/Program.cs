using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                List<string> arguments = command.Split(" - ").ToList();

                switch (arguments[0])
                {
                    case "Collect":
                        if (!inventory.Contains(arguments[1]))
                        {
                            inventory.Add(arguments[1]);
                        }
                        break;

                    case "Drop":
                        if (inventory.Contains(arguments[1]))
                        {
                            inventory.Remove(arguments[1]);
                        }
                        break;

                    case "Combine Items":
                        List<string> items = arguments[1].Split(":").ToList();
                        int oldItemIndex = inventory.IndexOf(items[0]);
                        if (oldItemIndex != -1)
                        {
                            if (oldItemIndex >= inventory.Count)
                            {
                                inventory.Add(items[1]);
                            }
                            else
                            {
                                inventory.Insert(oldItemIndex + 1, items[1]);
                            }
                        }
                        break;

                    case "Renew":
                        if (inventory.Contains(arguments[1]))
                        {
                            int itemIndex = inventory.IndexOf(arguments[1]);
                            if (itemIndex != -1)
                            {
                                string item = inventory[itemIndex];
                                inventory.RemoveAt(itemIndex);
                                inventory.Add(item);
                            }
                            //or
                            //inventory.Add(arguments[1]);
                            //inventory.Remove(arguments[1]);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
