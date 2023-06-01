using System;
using System.Linq;

namespace _00.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5]; // indexes [0 - names.len -1]
            names[0] = "H";
            names[1] = "e";
            names[2] = "l";
            names[3] = "l";
            names[4] = "o";
            for (int i = 0; i < names.Length; i++) 
            {
            Console.WriteLine(names[i]);
            }
            string nameComb = names[0] + names[1] + names[2] + names[3] + names[4];
            Console.WriteLine(nameComb);
            int[] ages = new int[] { 1, 4, 5, 7, 9 };


            string text = "10, 20, 30, 40, 50";
            string[] inputArray = text.Split(", ");
            int[] numbers = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                int number = int.Parse(inputArray[i]);
                numbers[i] = number;
            }
            Console.WriteLine(numbers[1] + numbers[2]);

            //OR

            int[] numbers2 = Console.ReadLine()
                .Split(", ") // ["10" "20" "30" "40" "50"]
                .Select(int.Parse) // 10 20 30 40 50  (x => int.Parse(x))
                .ToArray(); // [10 20 30 40 50]

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
            Console.WriteLine(numbers2[1] + numbers2[2]);
        }
    }
}
