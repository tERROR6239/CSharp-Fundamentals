﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();

            int messagesCount = int.Parse(Console.ReadLine());

            string starPattern = @"[SsTtAaRr]";
            string msgPattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

            for (int i = 0; i < messagesCount; i++)
            {
                string encryptMsg = Console.ReadLine();

                int decryptionKey = Regex.Matches(encryptMsg, starPattern).Count;

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < encryptMsg.Length; j++)
                {
                    sb.Append((char)(encryptMsg[j] - decryptionKey));
                }

                string encryptedMsg = sb.ToString();

                var match = Regex.Match(encryptedMsg, msgPattern);
                if (Regex.IsMatch(encryptedMsg, msgPattern) == false)
                {
                    continue;
                }

                string planetName = match.Groups["planet"].Value;
                uint population = uint.Parse(match.Groups["population"].Value);
                string attackType = match.Groups["type"].Value;
                uint soldierCount = uint.Parse(match.Groups["soldiers"].Value);

                Message message = new Message(planetName, population, attackType, soldierCount);

                messages.Add(message);
            }

            var planets = messages.Where(m => m.AttackType == "A")
                .OrderBy(m => m.PlanetName)
                .ToList();

            Console.WriteLine($"Attacked planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

            planets = messages.Where(m => m.AttackType == "D")
                .OrderBy(m => m.PlanetName)
                .ToList();

            Console.WriteLine($"Destroyed planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
        }

        class Message
        {
            public Message(string planetName, uint population, string attackType, uint soldierCount)
            {
                PlanetName = planetName;
                Population = population;
                AttackType = attackType;
                SoldierCount = soldierCount;
            }

            public string PlanetName { get; set; }

            public uint Population { get; set; }

            public string AttackType { get; set; }

            public uint SoldierCount { get; set; }
        }
    }
}



