using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string course;
            while ((course = Console.ReadLine()) != "end")
            {
                string[] arguments = course.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());                    
                }
                courses[courseName].Add(studentName);
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }         
            }
        }
    }
}
