namespace List07ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] token = command.Split();
                command = token[0];
                if (command == "Add")
                {
                    result.Add(int.Parse(token[1]));
                }

                if (command == "Remove")
                {
                    result.Remove(int.Parse(token[1]));
                }

                if (command == "RemoveAt")
                {
                    result.RemoveAt(int.Parse(token[1]));
                }

                if (command == "Insert")
                {
                    result.Insert(int.Parse(token[2]), int.Parse(token[1]));
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
        }
    }
}
