using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < list.Count / 2; i++)
            {
                int first = list[i];
                int last = list[list.Count - 1 - i];

                int sum = first + last;

                result.Add(sum);
            }

            if (list.Count % 2 == 1) 
            {
                result.Add(list[list.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
