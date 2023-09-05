using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.AdAstra1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(#|\|)(?<name>[a-zA-Z\s]+)(\1)(?<date>\d+\/\d+\/\d+)(\1)(?<calories>\d+)(\1)";
            Regex regex = new Regex(patern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            Dictionary<string, List<string>> products = new Dictionary<string, List<string>>();
            double sum = 0;
            double calories = 0;

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    string date = match.Groups["date"].Value;
                    calories = double.Parse(match.Groups["calories"].Value);
                    sum += calories;
                    products.Add(name, new List<string> { date, calories.ToString() });
                }
                Console.WriteLine($"You have food to last you for: {Math.Floor(sum / 2000)} days!");
                foreach (var item in products)
                {
                    Console.WriteLine($"Item: {item.Key}, Best before: {item.Value[0]}, Nutrition: {item.Value[1]}");
                }
            }
            else
            {
                Console.WriteLine($"You have food to last you for: {matches.Count} days!");
            }

        }
    }
}
