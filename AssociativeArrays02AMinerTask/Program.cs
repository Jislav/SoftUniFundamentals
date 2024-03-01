namespace AssociativeArrays02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = default;
            
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while((line = Console.ReadLine()) != "stop")
            {
                int amount = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(line))
                {
                    resources[line] += amount;
                }
                else
                {
                    resources.Add(line, amount);
                }
            }

            foreach(KeyValuePair<string, int> resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
