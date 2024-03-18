using System.Text;

namespace TextProcessing07StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int power = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    power += line[i + 1] - '0';
                    sb.Append(line[i]);
                }
                else if (power > 0)
                {
                    power--;
                }
                else
                {
                    sb.Append(line[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
