using System;
using System.Diagnostics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());


                decimal price = (days * capsulesCount) * pricePerCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }

            
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}

/*
1
1,53
30
8

2
4,99
31
3
0,35
31
5
*/
