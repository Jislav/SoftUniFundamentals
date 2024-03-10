

namespace MEAssociativeArrays02Judge
{
    class Participant
    {
        public Participant(string userName, Dictionary<string, int> contests)
        {
            Name = userName;
            Contests = contests;
        }

        public string Name { get; set; }

        public Dictionary<string, int> Contests { get; set; }

        public int Points => Contests.Values.Sum();

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = default;

            List<Participant> participants = new List<Participant>();

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            while ((line = Console.ReadLine()) != "no more time")
            {
                string[] tokens = line.Split(" -> ");

                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>() { { username, points } });
                }
                else
                {
                    if (contests[contest].ContainsKey(username))
                    {
                        if (contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                    else
                    {
                        contests[contest].Add(username, points);
                    }

                }

                bool userExists = false;

                foreach (Participant participant in participants)
                {
                    if (participant.Name == username)
                    {
                        userExists = true;
                        if (participant.Contests.ContainsKey(contest))
                        {
                            if (participant.Contests[contest] < points)
                            {
                                participant.Contests[contest] = points;
                            }
                        }
                        else
                        {
                            participant.Contests[contest] = points;
                        }
                    }
                }
                if (!userExists)
                {
                    Participant participant = new Participant(username, new Dictionary<string, int>() { { contest, points } });
                    participants.Add(participant);
                }
            }
            PrintContests(contests);
            PrintIndividualStandings(participants);
        }

        private static void PrintIndividualStandings(List<Participant> participants)
        {
            Console.WriteLine("Individual standings:");
            int i = 1;
            foreach (Participant participant in participants.OrderByDescending(x => x.Points).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{i}. {participant.Name} -> {participant.Points}");
                i++;
            }
        }

        private static void PrintContests(Dictionary<string, Dictionary<string, int>> contests)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Keys.Count} participants");
                int i = 1;
                foreach(KeyValuePair<string, int> user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x=> x.Key))
                {
                    Console.WriteLine($"{i}. {user.Key} <::> {user.Value}");
                    i++;
                }
            }

        }
    }
}
