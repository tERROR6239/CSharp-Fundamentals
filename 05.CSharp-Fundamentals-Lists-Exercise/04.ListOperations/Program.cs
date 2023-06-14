using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ');
                switch (arguments[0]) 
                {
                    case "Add":
                        int number = int.Parse(arguments[1]);
                        list = AddNumber(list, number);
                        break;
                    case "Insert":
                        list = InsertNumber(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        list = RemoveAtIndex(list, int.Parse(arguments[1]));
                        break;
                    case "Shift":
                        switch (arguments[1]) 
                        {
                            case "left":
                                list = ShiftLeft(list, int.Parse(arguments[2]));
                                break;
                            case "right":
                                list = ShiftRight(list, int.Parse(arguments[2]));
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        static List<int> AddNumber(List<int> list, int number)
        {
            list.Add(number);
            return list;
        }

        static List<int> InsertNumber(List<int> list, int number, int index)
        {
            if (IsIndexOutBoundery(list, index))
            {
                list.Insert(index, number);
            }            
            return list;
        }


        static List<int> RemoveAtIndex(List<int> list, int index)
        {
            if (IsIndexOutBoundery(list, index)) 
            {
                list.RemoveAt(index);
            }
            return list;
        }

        static List<int> ShiftLeft(List<int> list, int count)
        {
            count %= list.Count;
            List<int> shifted = list.GetRange(0, count);
            list.RemoveRange(0, count);
            list.InsertRange(list.Count, shifted);
            return list;
        }

        static List<int> ShiftRight(List<int> list, int count)
        {
            count %= list.Count;
            List<int> shifted = list.GetRange(list.Count - count, count);
            list.RemoveRange(list.Count - count, count);
            list.InsertRange(0, shifted);
            return list;
        }

        private static bool IsIndexOutBoundery(List<int> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index");
                return false;            
            }
            return true;
            
        }
    }
}
