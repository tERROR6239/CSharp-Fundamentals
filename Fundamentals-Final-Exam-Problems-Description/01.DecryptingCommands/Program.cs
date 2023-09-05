using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace _01.DecryptingCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string message = Console.ReadLine();
            int sum = 0;
            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] token = command.Split(" ").ToArray();

                switch (token[0])
                {
                    case "Replace":
                        string stringToBeRaolaced = token[1];
                        string replacment = token[2];
                        message = message.Replace(stringToBeRaolaced, replacment);
                        Console.WriteLine(message);
                        break;

                    case "Cut":                       
                        int startIndex = int.Parse(token[1]);
                        int endIndex = int.Parse(token[2]);
                        if (startIndex < 0 || endIndex > message.Length)
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        else
                        { 
                            int lenght = (endIndex - startIndex)+1;
                            message = message.Remove(startIndex, lenght);
                            Console.WriteLine(message);
                        }
                        break;

                    case "Make":
                        
                        if (token[1] == "Upper")
                        {
                            message = message.ToUpper();
                        }
                        else if (token[1] == "Lower")
                        {
                            message = message.ToLower();
                        }                        
                        Console.WriteLine(message);
                        break;

                    case "Check":
                        if (message.Contains(token[1]))
                        {
                            Console.WriteLine($"Message contains {token[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {token[1]}");
                        }

                        break;

                    case "Sum":
                        int startIndexSum = int.Parse(token[1]);
                        int endIndexSum = int.Parse(token[2]);
                        if (startIndexSum < 0 || endIndexSum > message.Length)
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        else
                        {
                            char[] substing = message.ToCharArray();
                            for (int i = startIndexSum; i <= endIndexSum; i++)
                            {
                                sum += substing[i];
                            }
                            Console.WriteLine(sum);
                        }
                        break;
                }
            }
        }
    }
}
