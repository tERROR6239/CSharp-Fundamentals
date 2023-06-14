﻿using System;

namespace _01._ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithoutTax = 0;
            bool isSpecial = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "special" || input == "regular") 
                {
                    if (input == "special")
                    {
                        isSpecial = true;
                    }

                    break;
                }

                double currentPrice = double.Parse(input);

                if (currentPrice < 0) 
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPriceWithoutTax += currentPrice;
            }
            if (totalPriceWithoutTax == 0) 
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double tax = totalPriceWithoutTax * 0.2;
            double totalPrice = totalPriceWithoutTax + tax;

            if (isSpecial)
            {
                totalPrice = totalPrice * 0.90;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:F2}$");
            Console.WriteLine($"Taxes: {tax:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:F2}$");
        }
    }
}
