namespace Methods02VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int result = CheckNumbersOfVowels(word);

            Console.WriteLine(result);
        }

        static int CheckNumbersOfVowels(string word)
        {
            int vowels = 0;

            word = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] is 'a' or 'o' or 'u' or 'e' or 'i')
                {
                    vowels++;
                }
                
            }

            return vowels;
        }
    }
}
