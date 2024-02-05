using System.Text;

namespace Methods03CharactersinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (secondChar < firstChar)
            {
                Console.WriteLine(PrintCharacters(secondChar, firstChar));
            }
            else
            {
                Console.WriteLine(PrintCharacters(firstChar, secondChar));
            }
        }

        static string PrintCharacters(char firstChar, char secondChar)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                sb.Append($"{(char)i} ");
            }
            return sb.ToString();
        }
    }
}
