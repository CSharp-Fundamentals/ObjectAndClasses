using System;
using System.Collections.Generic;

namespace TeamworkProjects
{
    class Program
    {
        class Team
        {
            public string Creator { get; set; }
            public string TeamName { get; set; }
            public List<string> Members { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamData = Console.ReadLine().Split("-");

                string creator = teamData[0];
                string teamName = teamData[1];

                if (TeamExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (CreatorExists(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                
                Team team = new Team
                    {
                        Creator = creator,
                        TeamName = teamName
                    };
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            while (true)
            {
                string line = Console.ReadLine();

                if (line=="end of assignemt")
                {
                    break;
                }

                string[] parts = line.Split("->");

                string user = parts[0];
                string teamName = parts[1];

                if (!TeamExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (IsMember(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                Team existingTeam = GetTeamByName(teams, teamName);
            }
            }

        private static Team GetTeamByName(List<Team> teams, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return team;
                }
            }
            return null;
        }

        private static bool IsMember(object user, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Creator == user)
                {
                    return true;
                }
                foreach (var member in team.Members)
                {
                    if (user == member)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        private static bool CreatorExists(List<Team> teams, string creator)
        {
            foreach (var team in teams)
            {
                if (team.Creator==creator)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool TeamExist(List<Team> teams, string teamName)
        {
            foreach (var team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
