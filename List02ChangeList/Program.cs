namespace List02ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split()
                .ToList();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                command = tokens[0];

                if(command == "Delete")
                {
                    numbers.RemoveAll(x => x == (tokens[1]));
                }
                else if(command == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), tokens[1]);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
