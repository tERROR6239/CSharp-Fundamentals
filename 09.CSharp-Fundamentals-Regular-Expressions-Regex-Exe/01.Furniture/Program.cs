using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnetures = new List<Furniture>();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<quantity>\d+)";  //https://regex101.com/r/YTM2sz/1
            string command;
            while ((command = Console.ReadLine()) != "Purchase")
            {
                //Regex r = new Regex(pattern);
                //MatchCollection collection = r.Matches(command);

                foreach (Match match in Regex.Matches(command, pattern))
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture f = new Furniture(name, price, quantity);
                    furnetures.Add(f);
                }

            }
                Console.WriteLine("Bought furniture:");
                decimal totalSpend = 0m;
                foreach (Furniture furniture in furnetures)
                {
                    Console.WriteLine(furniture.Name);
                    totalSpend += furniture.Total();
                }
                Console.WriteLine($"Total money spend: {totalSpend:f2}");
        }
    }

    class Furniture 
    {
        public Furniture(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}

