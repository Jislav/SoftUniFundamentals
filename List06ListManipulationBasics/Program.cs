namespace List06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultOriginal = new List<int>(result);

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] token = command.Split();
                command = token[0];
                if (command == "Add")
                {
                    result.Add(int.Parse(token[1]));
                }

                else if (command == "Remove")
                {
                    result.Remove(int.Parse(token[1]));
                }

                else if (command == "RemoveAt")
                {
                    result.RemoveAt(int.Parse(token[1]));
                }

                else if (command == "Insert")
                {
                    result.Insert(int.Parse(token[2]), int.Parse(token[1]));
                }

                else if (command == "Contains")
                {
                    if (result.Contains(int.Parse(token[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", result.Where(x => x % 2 == 0)));
                }

                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", result.Where(x => x % 2 != 0)));
                }

                else if (command == "GetSum")
                {
                    Console.WriteLine(result.Sum());
                }

                else if (command == "Filter")
                {
                    if (token[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", result.Where(x => x < int.Parse(token[2]))));
                    }
                    else if (token[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", result.Where(x => x > int.Parse(token[2]))));
                    }
                    else if (token[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", result.Where(x => x >= int.Parse(token[2]))));
                    }
                    else if (token[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", result.Where(x => x <= int.Parse(token[2]))));
                    }
                }
            }

            if (!result.SequenceEqual(resultOriginal))
            {
                Console.WriteLine(string.Join(" ", result));
            }
            
        }
    }
}
