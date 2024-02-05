using System.Text;

namespace Methods06MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = PrintMiddleCharacters(input);

            Console.WriteLine(result);
        }

        static string PrintMiddleCharacters(string input)
        {
            StringBuilder sb = new StringBuilder();

            int midChar = 0;

            if(input.Length % 2 == 0)
            {
                midChar = input.Length / 2;

                sb.Append($"{input[midChar - 1]}{input[midChar]}");
            }
            else
            {
                midChar = input.Length / 2;
                sb.Append(input[midChar]);
            }

            return sb.ToString();
        }
    }
}
