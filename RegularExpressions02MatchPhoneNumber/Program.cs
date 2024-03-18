using System.Text.RegularExpressions;

namespace RegularExpressions02MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359)([ |-])(2)(\2\d{3})(\2)(\d{4}\b)";
            string input = Console.ReadLine();

            MatchCollection phoneNumbers = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", phoneNumbers.Select(x => x.Groups[0])));
        }
    }
}
