using System.Linq;

namespace ObjectsAndClasses05Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split("-");

                string teamCreator = tokens[0];

                string teamName = tokens[1];

                bool validInput = true;

                foreach (Teams currentTeam in teams)
                {
                    if (teamCreator == currentTeam.TeamOwner)
                    {
                        Console.WriteLine($"{teamCreator} cannot create another team!");
                        validInput = false;
                    }
                    else if (teamName == currentTeam.TeamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        validInput = false;
                    }
                }

                if (validInput)
                {
                    List<string> members = new List<string>();
                    Teams team = new Teams(teamCreator, teamName, members);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
            }

            string line = default;

            while ((line = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = line.Split("->");
                {
                    string person = tokens[0];
                    string teamToJoin = tokens[1];

                    bool teamExists = false;

                    foreach (Teams team in teams)
                    {
                        if (teamToJoin == team.TeamName)
                        {
                            teamExists = true;
                        }
                    }


                    if (teamExists)
                    {
                        bool personIsNotInATeam = true;
                        foreach (Teams team in teams)
                        {
                            if (team.Members.Contains(person) || team.TeamOwner.Contains(person))
                            {
                                personIsNotInATeam = false;
                                break;
                            }
                        }
                        if (personIsNotInATeam)
                        {
                            foreach (Teams team in teams)
                            {
                                if (team.TeamName.Contains(teamToJoin))
                                {
                                    team.Members.Add(person);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Member {person} cannot join team {teamToJoin}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamToJoin} does not exist!");
                    }
                }
            }
           
            List<string> teamsToDisband = new List<string>();
            foreach (Teams team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.TeamOwner}");
                    foreach (string member in team.Members.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {member} ");
                    }
                }
                else
                {
                    teamsToDisband.Add(team.TeamName);
                }
            }
            
            Console.WriteLine("Teams to disband:");
            Console.WriteLine(string.Join(Environment.NewLine, teamsToDisband.OrderBy(x => x)));

        }
    }
    class Teams
    {
        public Teams(string teamCreator, string teamName, List<string> members)
        {
            TeamOwner = teamCreator;
            TeamName = teamName;
            Members = members;
        }
        public string TeamOwner { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}