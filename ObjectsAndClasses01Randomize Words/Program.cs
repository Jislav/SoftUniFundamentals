namespace ObjectsAndClasses01Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();

            for (int i = 0; i < words.Count; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(words.Count);

                string currentWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            } 

            Console.Write(string.Join(Environment.NewLine, words ));
        }
    }
}
