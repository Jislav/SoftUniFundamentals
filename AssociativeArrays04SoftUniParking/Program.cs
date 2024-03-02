

namespace AssociativeArrays04SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < commands; i++)
            {
                string command = Console.ReadLine();

                string[] tokens = command.Split();

                command = tokens[0];
               
                if (command == "register")
                {
                    string licensePlate = tokens[2];
                    parkingLot = RegisterAndValidate(parkingLot, tokens[1], tokens[2]);
                }
                else if(command == "unregister")
                {
                    parkingLot = RemoveUser(parkingLot, tokens[1]);
                }
            }
            foreach(KeyValuePair<string, string> user in parkingLot)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        public static Dictionary<string, string> RemoveUser(Dictionary<string, string> parkingLot, string username)
        {
            if (parkingLot.ContainsKey(username))
            {
                parkingLot.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
                return parkingLot;
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
                return parkingLot;
            }
        }

        public static Dictionary<string, string> RegisterAndValidate(Dictionary<string, string> parkingLot, string username, string licensePlate)
        {
            if (parkingLot.ContainsKey(username))
            {
                foreach (KeyValuePair<string, string> user in parkingLot)
                {
                    if (user.Key == username)
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {user.Value}");
                        break;
                    }
                }
                return parkingLot;
            }
            else
            {
                parkingLot.Add(username, licensePlate);
                Console.WriteLine($"{username} registered {licensePlate} successfully");
                return parkingLot;
            }
        }
    }
}
