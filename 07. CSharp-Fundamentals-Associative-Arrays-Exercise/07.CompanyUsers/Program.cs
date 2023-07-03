using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();

            string course;
            while ((course = Console.ReadLine()) != "End")
            {
                string[] arguments = course.Split(" -> ");
                string companyName = arguments[0];
                string employeId = arguments[1];

                if (!database.ContainsKey(companyName))
                {
                    database.Add(companyName, new List<string>());
                }

                if (!database[companyName].Contains(employeId))
                {
                    database[companyName].Add(employeId);
                }
            }

            foreach (var kvp in database)
            {
                Console.WriteLine(kvp.Key);
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }
        }
    }
}
