using System.Text;

namespace Methods07NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(PrintMatrix(number));
            int[] arr = { 1, 2, 3, 5 };
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static string PrintMatrix(int number)
        {
            StringBuilder matrix = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                if (i > 0)
                {
                    matrix.AppendLine();
                }
                for (int j = 0; j < number; j++)
                {
                    matrix.Append($"{number} ");
                }
            }
            return matrix.ToString();
        }
    }
}
