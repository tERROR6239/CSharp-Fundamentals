using System;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = ProcessExplosion(input);

            Console.WriteLine(output);
        }
        

        private static string  ProcessExplosion(string input)
        {
            StringBuilder sb = new StringBuilder();
            int strenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    strenght += int.Parse(input[i + 1].ToString());
                }
                else if (strenght == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    strenght--;
                }
            }

            return sb.ToString();
        }
    }
}
