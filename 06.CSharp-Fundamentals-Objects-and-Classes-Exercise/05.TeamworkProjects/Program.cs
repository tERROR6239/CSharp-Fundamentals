using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                string commmand = Console.ReadLine();
                string[] arguments = commmand.Split("-");
                string creatorName = arguments[0];
                string teamName = arguments[1];
                
                //Check for same creator
                Team sameCreator = teams.Find(team => team.Creator == creatorName);
                if (sameCreator != null)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }

                //Check for team name
                Team sameTeam = teams.Find(team => team.Name == teamName);
                if (sameTeam != null)
                {
                    Console.WriteLine($"Team {sameTeam.Name} was already created!");
                    continue;
                }

                Team team = new Team(teamName,creatorName);
                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string memberName = arguments[0];
                string teamName = arguments[1];
                

                //Check for same member in different team
                Team existMemeber = teams.Find(team => team.Members.Contains(memberName));
                
                if (existMemeber != null)
                { 
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }

                //Check if team exist
                //int findTeamIndex = teams.FindIndex(team => team.Name == teamName);
                Team findTeam = teams.Find(team => team.Name == teamName);
                if (findTeam != null)
                {
                    if (findTeam.Creator == memberName)
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    }
                    else
                    {
                        findTeam.Members.Add(memberName);
                    }
                }
                else 
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                //Console.WriteLine($"Team {teams[findTeamIndex].Name} is on Index: {findTeamIndex}");
            }

            List<Team> validTeams = teams.FindAll(team => team.Members.Count > 0);
            List<Team> disbandTeams = teams.FindAll(team => team.Members.Count == 0);

            validTeams = validTeams
                .OrderByDescending(team => team.Members.Count)  //sort by members count
                .ThenBy(team => team.Name) //Sort by name of the team 
                .ToList();

            disbandTeams = disbandTeams
               .OrderBy(team => team.Name)
               .ToList();
            //output
            foreach (Team team in validTeams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);                
            }
            //Console.WriteLine(string.Join("", teams));
        }
    }

    class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            Members.Sort();

            string result = "";
            result += Name + "\n";
            result += $"- {Creator}\n";
            foreach (string member in Members)
            {
                result += $"-- {member}\n";
            }
            return result.Trim();
        }
    }
}
