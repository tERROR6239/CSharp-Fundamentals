using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var kvp in students)
            {
                double average = kvp.Value.Average();
                if (average >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
                }
            }
        }
    }
}
