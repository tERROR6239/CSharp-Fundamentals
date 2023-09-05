using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] token = command.Split(">>>").ToArray();

                switch (token[0]) 
                {
                    case "Contains":
                        if (rawKey.Contains(token[1]))
                        {
                            Console.WriteLine($"{rawKey} contains {token[1]}");
                        }
                        else 
                        {
                            Console.WriteLine("Substring not found!");
                        }                        
                        break;

                    case "Flip":
                        int startIndex = int.Parse(token[2]);
                        int endIndex = int.Parse(token[3]);
                        int lenght = endIndex - startIndex;
                        string toUppOrLow = "";

                        if (token[1] == "Upper")
                        {
                            toUppOrLow = rawKey.Substring(startIndex, lenght).ToUpper();
                        }
                        else if (token[1] == "Lower")
                        {
                            toUppOrLow = rawKey.Substring(startIndex, lenght).ToLower();                            
                        }

                        rawKey = rawKey.Remove(startIndex, lenght);
                        rawKey = rawKey.Insert(startIndex, toUppOrLow);
                        Console.WriteLine(rawKey);
                        break;

                    case "Slice":
                        startIndex = int.Parse(token[1]);
                        endIndex = int.Parse(token[2]);
                        lenght = endIndex - startIndex;
                        rawKey = rawKey.Remove(startIndex, lenght);
                        Console.WriteLine(rawKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
