using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double money = 0.0;
            double coin = 0.0;

            while (command != "Start")
            {
                coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    money += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {                
                if (command == "Nuts")
                {
                    if (money >= 2.0)
                    {
                        money -= 2.0;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Water")
                {
                    if (money >= 0.7)
                    {
                        money -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        money -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Soda")
                {
                    if (money >= 0.8)
                    {
                        money -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Coke")
                {
                    if (money >= 1.0)
                    {
                        money -= 1.0;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");
        }
    }
}
