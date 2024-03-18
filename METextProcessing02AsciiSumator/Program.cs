using System.Text;

namespace METextProcessing02AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char[] line = Console.ReadLine().ToCharArray();

            int sum = 0;

            line = line.Where(x => x > firstChar && x < secondChar).ToArray();

            for (int i = 0; i < line.Length; i++)
            {
                sum += line[i];
            }
            Console.WriteLine(sum);
        }
    }
}
