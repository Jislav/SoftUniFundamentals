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
                    if (teamName == currentTeam.TeamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        validInput = false;
                    }

                    if (teamCreator == currentTeam.TeamOwner)
                    {
                        Console.WriteLine($"{teamCreator} cannot create another team!");
                        validInput = false;
                    }
                }

                if (validInput)
                {
                    Teams team = new Teams(teamCreator, teamName);
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

                    bool personIsNotInATeam = true;

                    if (teamExists)
                    {
                        foreach (Teams team in teams)
                        {
                            if (team.Members == null)
                            {
                                continue;
                            }
                            else
                            {
                                bool personIsNotOnATeam = true;
                                foreach (string member in team.Members)
                                {
                                    if (member.ToString() == person)
                                    {
                                        Console.WriteLine($"Member {person} cannot join team {teamToJoin}!");
                                        personIsNotOnATeam = false;
                                        break;
                                    }
                                }
                                if(personIsNotInATeam)
                                {
                                    foreach(Teams t in teams)
                                    {
                                        if(t.TeamName == teamToJoin)
                                        {
                                            List<string> members = t.Members;
                                            members.Add(person);
                                            t.Members = members;
                                        }
                                    }

                                }
                            }
                        }
                        //foreach (Teams team in teams)
                        //{
                        //    List<string> currentTeamMembers = new();
                        //    if (currentTeamMembers.Contains(person))
                        //    {
                        //        Console.WriteLine($"Member {person} cannot join team {teamToJoin}!");
                        //        personIsNotInATeam = false;
                        //        break;
                        //    }
                        //}
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamToJoin} does not exist!");
                        continue;
                    }
                }
            }
            foreach (Teams team in teams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.TeamOwner}");
                
            }
        }
    }
    class Teams
    {
        public Teams(string teamCreator, string teamName)
        {
            TeamOwner = teamCreator;
            TeamName = teamName;
        }
        public string TeamOwner { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
    //class Members
    //{
    //    public Members()
    //    {
    //        TeamMembers = new List<string>();
    //    }

    //    public List<string> TeamMembers { get; set; }
    //}

}