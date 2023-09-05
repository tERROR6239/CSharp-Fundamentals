using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caloriesPerDay = 2000;
            string input = Console.ReadLine();
            string pattern = @"(#|\|)([a-zA-Z\s]+)(\1)(\d{2}\/\d{2}\/\d{2})(\1)(\d+)(\1)";
           
            List<Product> products = new List<Product>();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string itemName = match.Groups[2].Value;
                string expirationDate = match.Groups[4].Value;
                int calories = int.Parse(match.Groups[6].Value);
                products.Add(new Product(itemName, expirationDate, calories));
            }

            int days = products.Sum(x => x.Calories) / caloriesPerDay;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Product product in products)
            {
                Console.WriteLine($"Item: {product.ItemName}, Best before: {product.ExpirationDate}, Nutrition: {product.Calories}");
            }
        }

        public class Product
        {
            public Product(string itemName, string expirationDate, int calories)
            {
                ItemName = itemName;
                ExpirationDate = expirationDate;
                Calories = calories;
            }

            public string ItemName { get; set; }
            public string ExpirationDate { get; set; }
            public int Calories { get; set; }
        }

    }
}
