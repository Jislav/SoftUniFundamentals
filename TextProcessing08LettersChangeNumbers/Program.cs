
using System.Text;

namespace TextProcessing08LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<decimal> values = new List<decimal>();

            for (int i = 0; i < text.Length; i++)
            {
                string currentString = text[i];


                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];

                decimal number = GetNumber(currentString);

                decimal sum = 0;

                if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    sum += number * (firstLetter - 96);
                }
                else if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    firstLetter = char.ToLower(firstLetter);
                    sum += number / (firstLetter - 96);
                }
                if (lastLetter >= 'a' && lastLetter <= 'z')
                {
                    sum += lastLetter - 96;
                }
                else if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    lastLetter = char.ToLower(lastLetter);
                    sum -= lastLetter - 96;
                }

                values.Add(sum);
            }
            Console.WriteLine($"{values.Sum():f2}");
        }
        public static decimal GetNumber(string text)
        {
            char[] numbers = text.Where(x => char.IsDigit(x)).ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                sb.Append(numbers[i]);
            }
            return decimal.Parse(sb.ToString());
        }
    }
}
