using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "a", "b", "c", "d", "e" };

            for (int i = 0; i < array.Length / 2; i++)
            {
                string firstElement = array[i];
                string lastElelment = array[array.Length - i - 1];

                array[i] = lastElelment;
                array[array.Length - i - 1] = firstElement;

                //or

                //array[^(1 + i)] = firstElement;

                // var arr = array[^1]; -> array.Lenght - 1
                // var arr = array[1..2] -> b , [1..] -> b c d e , [..2] -> a b
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //or

            //Console.WriteLine(string.Join(' ', array));
        }
    }
}
