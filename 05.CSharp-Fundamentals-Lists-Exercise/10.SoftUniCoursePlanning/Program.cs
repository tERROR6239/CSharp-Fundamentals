using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "course start") 
            {
                string[] arguments = commands.Split(":");
                switch (arguments[0])
                {
                    case "Add":
                        schedule = AddTitle(schedule, arguments[1]);
                        break;
                    case "Insert":
                        schedule = InsertTitle(schedule, arguments[1], int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        schedule = RemoveTitle(schedule, arguments[1]);
                        break;
                    case "Swap":
                        schedule = SwapTitles(schedule, arguments[1], arguments[2]);
                        break;
                    case "Exercise":
                        schedule = InsertExercise(schedule, arguments[1]);
                        break;

                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }            
        }
         
        static List<string> AddTitle(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))
            {
                schedule.Add(title);
            }
            return schedule;
        }

        static List<string> InsertTitle(List<string> schedule, string title, int index)
        {
            if (!schedule.Contains(title))
            {
                schedule.Insert(index, title);
            }
            return schedule;
        }

        static List<string> RemoveTitle(List<string> schedule, string title)
        {
            if (schedule.Contains(title))
            {
                schedule.Remove(title);  
            }

            string exerciseTitle = $"{title}-Exercise";
            int index = schedule.IndexOf(exerciseTitle);

            if (index >= 0)
            {
                RemoveTitle(schedule, exerciseTitle);                
            }
            return schedule;
        }

        static List<string> SwapTitles(List<string> schedule, string firstTitle, string secondTitle)
        {
            if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle))
            {
                int firstTitleIndex = schedule.IndexOf(firstTitle);
                int secondTitleIndex = schedule.IndexOf(secondTitle);

                string temp = schedule[firstTitleIndex];
                schedule[firstTitleIndex] = schedule[secondTitleIndex];
                schedule[secondTitleIndex] = temp;

                schedule = SwapExercise(schedule, firstTitle, secondTitleIndex);
                schedule = SwapExercise(schedule, secondTitle, firstTitleIndex);
            }
            return schedule;
        }

        static List<string> SwapExercise(List<string> schedule, string title, int titleIndex)
        {
            string exerciseTitle = $"{title}-Exercise";
            int index = schedule.IndexOf(exerciseTitle);

            if (index >= 0) 
            {
                RemoveTitle(schedule, exerciseTitle);
                InsertTitle(schedule, exerciseTitle, titleIndex + 1);
            }    

            return schedule;
        }

        static List<string> InsertExercise(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))
            {
                AddTitle(schedule, title);
            }

            string exerciseTitle = $"{title}-Exercise";
            if (schedule.Contains(title) && !schedule.Contains(exerciseTitle))
            {
                int indexTitle = schedule.IndexOf(title);
                InsertTitle(schedule, exerciseTitle, indexTitle + 1);
            }

            return schedule;
        }
    }
}