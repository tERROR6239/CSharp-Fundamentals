using System;
using System.Collections.Generic;

namespace _00.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            
            List<int> numbers2 = new List<int>(); //deklaraciq
            numbers2.Add(1); //dobavqne v listta
            numbers2.Add(2); //dobavq vinagi naj otzad

            List<int> numbers3 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers3.Add(i);
            }
            numbers3[4] = 5;  // samo ako ve4e imame ele 5
            int numberAtIndex4 = numbers3[4] + numbers3[5];
            Console.WriteLine(numbers3.Count);  //broj kletki v listta
            numbers3.Remove(numbers3[4]);
            numbers3.Remove(5); //iztriva element i premestva ostanalite nagore  vru6ta bool
            numbers3.Insert(1, 8); //dobavq element na daden indeks i izmestva vsi4ki ostanali nadolo
            numbers3.Contains(2); //proverqva za nali`nost na stojnostta vry6ta bool
            numbers3.Sort(); //narejda elementite - po azbu4en red - 
        }
    }
}
