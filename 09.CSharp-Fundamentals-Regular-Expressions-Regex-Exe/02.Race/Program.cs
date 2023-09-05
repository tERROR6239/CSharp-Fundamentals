using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Participant> participants = new List<Participant>();
            string[] namesArr = Console.ReadLine().Split(", ");

            for (int i = 0; i < namesArr.Length; i++)
            {
                Participant participant = new Participant();
                participant.Name = namesArr[i];
                participant.Distance = 0;
                participants.Add(participant);
            }


            string lettersPattern = @"[A-Za-z]";
            string digitsPattern = @"\d";

            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                StringBuilder name = new StringBuilder();

                foreach (Match match in Regex.Matches(command, lettersPattern)) 
                {
                    name.Append(match.Value);
                }

                uint distance = 0;
                foreach (Match match in Regex.Matches(command, digitsPattern))
                {
                    distance += uint.Parse(match.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(p => p.Name == name.ToString());
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
            }

            List<Participant> OrderedParticipants = participants
                .OrderByDescending(p => p.Distance)
                .Take(3)
                .ToList();

            if (participants.Count >= 3)
            {
                Console.WriteLine($"1st place: {OrderedParticipants[0].Name}");
                Console.WriteLine($"2nd place: {OrderedParticipants[1].Name}");
                Console.WriteLine($"3rd place: {OrderedParticipants[2].Name}");
            }
        }

        class Participant
        {
            public string Name { get; set; }
            public uint Distance { get; set; }
        }

    }
}
