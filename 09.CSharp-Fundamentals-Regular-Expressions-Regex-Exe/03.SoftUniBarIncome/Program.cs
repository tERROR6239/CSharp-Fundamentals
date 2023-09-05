using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+|\d+\.\d+)\$";

            string input;
            decimal income = 0m;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Order order = new Order();
                    order.Customer = match.Groups["customer"].Value;
                    order.Product = match.Groups["product"].Value;
                    order.Count = uint.Parse(match.Groups["count"].Value);
                    order.Price = decimal.Parse(match.Groups["price"].Value);
                    
                    Console.WriteLine($"{order.Customer}: {order.Product} - {order.Total():f2}");
                    income += order.Total();
                }

            }
            Console.WriteLine($"Total income: {income:f2}");
        }

        class Order
        {
            public string Customer { get; set; }
            public string Product { get; set; }
            public uint Count { get; set; }
            public decimal Price { get; set; }

            public decimal Total()
            {
                return Price * Count;
            }
        }
    }
}
