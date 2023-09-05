﻿using System;
using System.Linq;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(string.Join("", text.Where(char.IsDigit)));
            Console.WriteLine(string.Join("", text.Where(char.IsLetter)));
            Console.WriteLine(string.Join("", text.Where(x => !char.IsLetterOrDigit(x))));
        }
    }
}
