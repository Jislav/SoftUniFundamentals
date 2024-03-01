namespace AssociativeArrays01CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();
            foreach (string word in words)
            {
                foreach(char letter in word)
                {
                    if(lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter]++;
                    }
                    else
                    {
                        lettersCount.Add(letter, 1);
                    }
                }
            }
            foreach(KeyValuePair<char, int> letter in lettersCount)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
