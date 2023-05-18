using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int facturiel = 1;
            int digit = 0;
            int summ = 0;
            bool calculate = true;

            while (calculate)
            {
                digit = temp % 10;

                for (int i = 1; i <= digit; i++)
                {
                    facturiel *= i;
                }
                summ += facturiel;
                facturiel = 1;

                temp = temp / 10;

                if (temp == 0)
                {
                    break;
                }                
            }

            if (number == summ)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }
        }
    }
}
