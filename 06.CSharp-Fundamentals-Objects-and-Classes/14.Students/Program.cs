using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end") 
            {
                string[] tokens = input.Split(" ").ToArray();

                students.Add(new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]));


            }

            string cityName = Console.ReadLine();

            //List<Student> filterStudents = students.Where(x => x.HomeTown == cityName).ToList(); 
            //or

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }

    public class Student 
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
