namespace MEAssociativeArrays01Ranking
{
    class User
    {
        public User(string username, Dictionary<string, int> contestsAndPoints)
        {
            Username = username;
            ContestsAndPoints = contestsAndPoints;
        }
        public string Username { get; set; }

        public Dictionary<string, int> ContestsAndPoints { get; set; }

        public int Points => ContestsAndPoints.Values.Sum();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            Dictionary<string, string> contests = new();

            string line = default;

            while ((line = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = line.Split(":");

                string username = tokens[0];
                string password = tokens[1];

                contests.Add(username, password);
            }

            while ((line = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = line.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];

                if (contests.ContainsKey(contest))
                {
                    string password = tokens[1];
                    if (contests[contest] == password)
                    {
                        string username = tokens[2];
                        int points = int.Parse(tokens[3]);

                        users = AddUser(username, users, points, contest);
                    }
                }
            }
            PrintBestCandidate(users);

            PrintAllStudents(users);

        }

        private static void PrintAllStudents(List<User> users)
        {
            Console.WriteLine("Ranking: ");
            foreach (User user in users.OrderBy(x => x.Username))
            {
                Console.WriteLine(user.Username);
                foreach (KeyValuePair<string, int> contest in user.ContestsAndPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        private static void PrintBestCandidate(List<User> users)
        {
            string bestCandidate = default;
            int highestPoints = 0;
            foreach (User user in users)
            {
                if (highestPoints < user.Points)
                {
                    bestCandidate = user.Username;
                    highestPoints = user.Points;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {highestPoints} points.");
        }

        static List<User> AddUser(string username, List<User> users, int points, string contest)
        {
            bool userExists = false;
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    userExists = true;
                    break;
                }
            }
            if (userExists)
            {
                foreach (User user in users)
                {
                    if (user.Username == username)
                    {
                        if (user.ContestsAndPoints.ContainsKey(contest))
                        {
                            if (user.ContestsAndPoints[contest] < points)
                            {
                                user.ContestsAndPoints[contest] = points;
                                return users;
                            }
                            return users;
                        }
                        else
                        {
                            user.ContestsAndPoints.Add(contest, points);
                            return users;
                        }
                    }
                }
            }
            User newUser = new User(username, new Dictionary<string, int>() { { contest, points } });
            users.Add(newUser);
            return users;

        }
    }
}

