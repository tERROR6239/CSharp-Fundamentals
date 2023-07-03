using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();           

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] argguments = commands.Split(' ');
                

                if (argguments[0] == "Delete")
                {
                    int element = int.Parse(argguments[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == element)
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else if (argguments[0] == "Insert")
                {
                    int element = int.Parse(argguments[1]);
                    int position = int.Parse(argguments[2]);
                    list.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
