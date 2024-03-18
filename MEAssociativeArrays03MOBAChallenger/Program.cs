using System.Dynamic;
using System.Numerics;

namespace MEAssociativeArrays03MOBAChallenger
{
    class Player
    {
        public Player(string name, Dictionary<string, int> positionsAndSkill)
        {
            Name = name;
            Positions = positionsAndSkill;
        }

        public string Name { get; set; }

        public Dictionary<string, int> Positions { get; set; }

        public int Skill => Positions.Values.Sum();
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            string line = default;

            List<Player> playerList = new List<Player>();

            while ((line = Console.ReadLine()) != "Season end")
            {
                string[] tokens = line.Split(new string[] { " -> ", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[1] != "vs")
                {
                    string name = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);
                    if (PlayerExists(playerList, name))
                    {
                        if (PlayerHasPosition(playerList, position, name))
                        {
                            EditPosition(playerList, skill, position, name);
                        }
                        else
                        {
                            AddPositionToPlayer(playerList, skill, position, name);
                        }
                    }
                    else
                    {
                        Player player = new Player(name, new Dictionary<string, int> { { position, skill } });
                        playerList.Add(player);
                    }
                }
                else
                {
                    string playerOne = tokens[0];
                    string playerTwo = tokens[2];

                    if (BothPlayersExist(playerOne, playerTwo, playerList))
                    {
                        Battle(playerOne, playerTwo, playerList);
                    }
                }
            }
            PrintPlayers(playerList);
        }

        public static void PrintPlayers(List<Player> playerList)
        {
            foreach (Player player in playerList.OrderByDescending(x => x.Skill).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{player.Name}: {player.Skill} skill");
                foreach (var kvp in player.Positions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
        public static List<Player> Battle(string playerOne, string playerTwo, List<Player> playerList)
        {
            foreach (Player player1 in playerList)
            {
                if (player1.Name == playerOne)
                {
                    foreach (Player player2 in playerList)
                    {
                        if (player2.Name == playerTwo)
                        {
                            foreach (var kvp1 in player1.Positions)
                            {
                                if (player2.Positions.ContainsKey(kvp1.Key))
                                {
                                    if (player1.Skill > player2.Skill)
                                    {
                                        playerList.Remove(player2);
                                        return playerList;
                                    }
                                    else if (player1.Skill < player2.Skill)
                                    {
                                        playerList.Remove(player1);
                                        return playerList;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return playerList;
        }
        public static bool BothPlayersExist(string playerOne, string playerTwo, List<Player> playerList)
        {
            bool playerOneExists = false;
            bool playerTwoExists = false;

            foreach (Player player in playerList)
            {
                if (player.Name == playerOne)
                {
                    playerOneExists = true;
                }
                if (player.Name == playerTwo)
                {
                    playerTwoExists = true;
                }
            }
            if (playerTwoExists && playerOneExists)
            {
                return true;
            }
            return false;
        }
        public static List<Player> AddPositionToPlayer(List<Player> playerList, int skill, string position, string name)
        {
            foreach (Player player in playerList)
            {
                if (player.Name == name)
                {
                    player.Positions.Add(position, skill);
                }
            }
            return playerList;
        }
        public static List<Player> EditPosition(List<Player> playerList, int skill, string position, string name)
        {
            foreach (Player player in playerList)
            {
                if (player.Name == name)
                {
                    if (player.Positions.ContainsKey(position))
                    {
                        if (player.Positions[position] < skill)
                        {
                            player.Positions[position] = skill;
                        }
                    }
                }

            }
            return playerList;
        }
        public static bool PlayerHasPosition(List<Player> playerList, string position, string name)
        {
            foreach (Player player in playerList)
            {
                if (player.Name == name)
                {
                    if (player.Positions.ContainsKey(position))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool PlayerExists(List<Player> playerList, string name)
        {
            foreach (Player player in playerList)
            {
                if (player.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}