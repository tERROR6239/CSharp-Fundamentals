using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"(?:@#+)(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])(?:@#+)";
                string patternGroup = @"[0-9]";

                if (Regex.Matches(input, pattern).Count > 0)
                {
                    string group = "";
                    foreach (Match m in Regex.Matches(input, patternGroup))
                    {                                                
                        group += m.Value;                        
                    }
                    if (group == "")
                    {
                        group = "00";
                    }
                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

                
            }
        }
    }
}



