using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            int vowels = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (VowelsCondition(arr, i))
                {
                    vowels++;
                }
            }

            Console.WriteLine(vowels);
        }

        static bool VowelsCondition(char[] arr, int i)
        {
            return arr[i] == 'a' || arr[i] == 'A' ||
                                arr[i] == 'o' || arr[i] == 'O' ||
                                arr[i] == 'u' || arr[i] == 'U' ||
                                arr[i] == 'e' || arr[i] == 'E' ||
                                arr[i] == 'i' || arr[i] == 'I';
        }
    }
}
