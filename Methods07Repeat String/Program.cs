using System.Text;

namespace Methods07Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(n, input);

            Console.WriteLine(result);
            
        }

        static string RepeatString(int n, string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(input);
            }

            return sb.ToString();
        }
    }
}
