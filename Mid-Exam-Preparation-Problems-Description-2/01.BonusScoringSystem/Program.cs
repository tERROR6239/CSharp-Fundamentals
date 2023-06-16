 using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lectureCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

           
            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double bonus = (double)attendance / lectureCount * (5 + additionalBonus);

                if (maxBonus < bonus)
                {
                    maxBonus = bonus;
                    maxAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
} 
