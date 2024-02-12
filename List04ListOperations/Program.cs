namespace List04ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();

                command = tokens[0];

                if (command == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (command == "Insert")
                {
                    if (CheckIndex(int.Parse(tokens[2]), numbers.Count))
                    {
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (command == "Remove")
                {
                    if (CheckIndex(int.Parse(tokens[1]), numbers.Count))
                    {
                        numbers.RemoveAt(int.Parse(tokens[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                        
                }
                else if (command == "Shift")
                {
                    if (tokens[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(tokens[2]); i++)
                        {
                            numbers.Add(numbers.First());
                            numbers.RemoveAt(0);
                        }

                    }
                    else if (tokens[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(tokens[2]); i++)
                        {
                            numbers.Insert(0, numbers.Last());
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool CheckIndex(int token, int lastIndex)
        {
            if (token <= lastIndex && token >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
