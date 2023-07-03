using System;
using System.Linq;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
              /*
               Console
                .ReadLine()
                .Split(' ')
                .Where(w => w.Length % 2 == 0)
                .Select(x => x.ToLower())
                .ToList()
                .ForEach(Console.WriteLine);
              */

            string[] word = Console
                .ReadLine()
                .Split(' ')
                .Where(w => w.Length % 2 == 0)
                .Select(x => x.ToLower())
                .ToArray();

                Console.WriteLine(string.Join(" ", word));
        }
    }
}
