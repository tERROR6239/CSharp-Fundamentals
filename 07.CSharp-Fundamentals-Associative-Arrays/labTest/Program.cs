using System;
using System.Collections.Generic;


namespace labTest
{
    internal class Program
    {
        private static object kvp;

        static void Main(string[] args)
        {
            string[] students = new string[5];
            students[0] = "Filip";
            students[1] = "Terry";
            students[2] = "Stoyan";

            string[] facultyNumber = new string[5];
            students[0] = "1234567";
            students[1] = "1345627";
            students[2] = "7654321";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i]} --> FN: {facultyNumber[i]}");
            }

            Dictionary<string, string> names = new Dictionary<string, string>();
            names["Filip"] = "432454366";
            names["Ivan"] = "231243435";
            names["Joro"] = "432543696";
            names.Add("Bobi", "12345678");
            names.Remove("Ivan");

            foreach (var kvp in names)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
                Console.WriteLine();
            }

            var phoneBook = new SortedDictionary<string, List<string>>()
            {
                {"Filip", new List<string>{"089897", "089896"} }
            };
            phoneBook["Gosho"] = new List<string>();
            phoneBook["Gosho"].Add("089893");
            phoneBook["Gosho"].Add("089894");

            phoneBook.Add("Ivan", new List<string> { "088734" });

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine(string.Join(", ", kvp.Value));
            }
        }
        public class KeyValue<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
    }
}
