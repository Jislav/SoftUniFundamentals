namespace List03HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> peopleGoing = new List<string>();

            for (int i = 0; i < numberOfCommands; i++) 
            {
                string command = Console.ReadLine();

                string[] tokens = command.Split();

                if (tokens[2] == "going!")
                {
                    if (CheckIfPersonIsOnTheList(tokens[0], peopleGoing))
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                    else
                    {
                        peopleGoing.Add(tokens[0]);
                    }
                }
                else
                {
                    if (CheckIfPersonIsOnTheList(tokens[0], peopleGoing))
                    {
                        peopleGoing.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join("\n", peopleGoing));
        }
        static bool CheckIfPersonIsOnTheList(string name, List<string> peopleGoing)
        {
            bool personIsOnTheList = false;

            if(peopleGoing.Contains(name))
            {
                return personIsOnTheList = true;
            }

            return personIsOnTheList;
        }
    }
}
