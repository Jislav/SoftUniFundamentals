namespace AssociativeArrays03WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if(result.ContainsKey(word))
                {
                    result[word].Add(synonym);
                }
                else
                {
                    result[word] = new List<string>();
                    result[word].Add(synonym);
                }
            }
            foreach(var word in result)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
