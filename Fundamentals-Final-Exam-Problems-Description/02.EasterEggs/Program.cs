using System;
using System.Text.RegularExpressions;

namespace _02.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();                

            string pattern = @"[@#]+(?<Colour>[a-z]{3,})[@#]+(\D\W*?)\/+(?<Digit>\d+)\/+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string color = match.Groups["Colour"].Value;
                string amount = match.Groups["Digit"].Value;
                                
                Console.WriteLine($"You found {amount} {color} eggs!");            
            }
        }       
    } 
}
    