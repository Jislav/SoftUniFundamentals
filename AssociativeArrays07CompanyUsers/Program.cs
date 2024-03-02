namespace AssociativeArrays07CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string line = default;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (!companies.ContainsKey(tokens[0]))
                {
                    companies.Add(tokens[0], new List<string>() { tokens[1] });
                }
                else
                {
                    if (!companies[tokens[0]].Contains(tokens[1]))
                    {
                        companies[tokens[0]].Add(tokens[1]);
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (string id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
