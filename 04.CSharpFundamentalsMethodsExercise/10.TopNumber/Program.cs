using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int num)
        {
            if (IsDivByEight(num) && HasOddNum(num))
            {
                return true;
            }
            return false;
        }

        static bool HasOddNum(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }


        static bool IsDivByEight(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum  += digit;
                num /= 10;
            }
            return sum % 8 == 0;
        }
    }
}
