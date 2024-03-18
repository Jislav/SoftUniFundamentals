using System.Text.RegularExpressions;

namespace RegulerExpressions01MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string input = Console.ReadLine();

            var names = Regex.Matches(input, pattern);

            foreach (Match name in names )
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
