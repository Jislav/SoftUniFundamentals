using System.Text.RegularExpressions;

namespace RegularExpressions03MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<days>\d{2})([\.|\-|\/])(?<months>[A-Z][a-z]{2})(\1)(?<years>\d{4})";
            string input = Console.ReadLine();

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                Console.Write($"Day: {date.Groups["days"].Value}, ");
                Console.Write($"Month: {date.Groups["months"].Value}, ");
                Console.Write($"Year: {date.Groups["years"].Value}");
                Console.WriteLine();
            }
        }
    }
}
