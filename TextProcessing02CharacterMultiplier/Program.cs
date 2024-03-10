
namespace TextProcessing02CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split()
                .ToArray();
            PrintSum(strings[0], strings[1]);
        }

        private static void PrintSum(string firstString, string secondString)
        {
            int bigString = Math.Max(firstString.Length, secondString.Length);

            int smallString = Math.Min(firstString.Length, secondString.Length);

            char[] stringsCombined = (firstString + secondString).ToCharArray();
            if(firstString.Length > secondString.Length)
            {
                stringsCombined = (secondString + firstString).ToCharArray();
            }
            int sum = 0;

            for (int i = 0; i < bigString; i++)
            {
                if (smallString > i)
                {
                    sum += firstString[i] * secondString[i];
                }
                else
                {
                    sum += stringsCombined[i + smallString];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
