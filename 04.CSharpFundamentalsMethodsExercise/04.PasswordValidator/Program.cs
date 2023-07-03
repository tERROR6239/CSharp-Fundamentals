using System;
using System.Linq;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();
            if (password.Length > 0)
            {
                int digitsCount = 0;
                bool isValid = true;
                bool isOnlyLetersAndDigits = true;
                bool isAtLeast2Digits = true;
                isValid = CheckPasswordLength(password, isValid);
                CheckPasswordSymbols(password, ref digitsCount, ref isValid, ref isOnlyLetersAndDigits);
                CheckDigitsCount(digitsCount, ref isValid, ref isAtLeast2Digits);

                if (!isOnlyLetersAndDigits)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!isAtLeast2Digits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

                if (isValid)
                {
                    Console.WriteLine("Password is valid");
                }
            }

        }

        static void CheckDigitsCount(int digitsCount, ref bool isValid, ref bool isAtLeast2Digits)
        {
            if (digitsCount < 3)
            {
                isAtLeast2Digits = false;
                isValid = false;
            }
        }

        static void CheckPasswordSymbols(char[] password, ref int digitsCount, ref bool isValid, ref bool isOnlyLetersAndDigits)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] > 47 && password[i] < 58 ||
                    password[i] > 64 && password[i] < 91 ||
                    password[i] > 96 && password[i] < 123))
                {
                    isOnlyLetersAndDigits = false;
                    isValid = false;
                }

                if (password[i] > 47 && password[i] < 58)
                {
                    digitsCount++;
                }
            }
        }

        static bool CheckPasswordLength(char[] password, bool isValid)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            return isValid;
        }
    }
}
