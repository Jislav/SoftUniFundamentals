using System.Text;

namespace METextProcessing03TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string line = default;
            List<string> strings = new List<string>();

            Dictionary<string, string> messages = new Dictionary<string, string>();

            while((line = Console.ReadLine()) != "find")
            {
                strings.Add(line);
            }

            for (int i = 0; i < strings.Count; i++)
            {
                StringBuilder message = new StringBuilder();

                int keyIndex = 0;

                for (int j = 0; j < strings[i].Length; j++)
                {
                    message.Append($"{(char)(strings[i][j] - key[keyIndex])}");

                    if(keyIndex == key.Length - 1)
                    {
                        keyIndex = 0;
                    }
                    else
                    {
                        keyIndex++;
                    }
                }
                string currentMessage = message.ToString();

                string treasure = currentMessage.Substring(currentMessage.IndexOf('&') + 1, currentMessage.LastIndexOf('&') - currentMessage.IndexOf('&') - 1);
                string cordinates  = currentMessage.Substring(currentMessage.IndexOf('<') + 1, currentMessage.LastIndexOf('>') - currentMessage.IndexOf('<') - 1);
                messages.Add(treasure, cordinates);
            }

            foreach(KeyValuePair<string, string> kvp in messages)
            {
                Console.WriteLine($"Found {kvp.Key} at {kvp.Value}");
            }
        }
    }
}
