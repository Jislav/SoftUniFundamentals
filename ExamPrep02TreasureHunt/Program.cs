namespace ExamPrep02TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split("|")
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] tokens = command.Split();
                command = tokens[0];

                if (command == "Loot")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        if (items.Contains(tokens[i]))
                        {
                            continue;
                        }

                        items.Insert(0, tokens[i]);

                    }
                }
                else if (command == "Drop")
                {
                    if (int.Parse(tokens[1]) < 0 || int.Parse(tokens[1]) > items.Count - 1)
                    {
                        continue;
                    }
                    items.Add(items[int.Parse(tokens[1])]);
                    items.RemoveAt(int.Parse(tokens[1]));
                }
                else if (command == "Steal")
                {
                    int stealCount = int.Parse(tokens[1]);

                    if (stealCount > items.Count)
                    {
                        Console.WriteLine(string.Join(", ", items));
                        items.Clear();
                    }
                    else
                    {
                        List<string> stolenItems = new List<string>();

                        for (int i = 0; i < stealCount; i++)
                        {
                            stolenItems.Add(items[items.Count - stealCount + i]);
                        }
                        items.RemoveRange(items.Count - stealCount, stealCount);
                        Console.WriteLine(string.Join(", ", stolenItems));
                    }
                }
            }
            if(items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sum = 0;

                for (int i = 0; i < items.Count; i++)
                {
                    sum += items[i].Length;
                }
                double averageLoot = sum / items.Count;
                Console.WriteLine($"Average treasure gain: {averageLoot:f2} pirate credits.");
            }
            
        }
    }
}
