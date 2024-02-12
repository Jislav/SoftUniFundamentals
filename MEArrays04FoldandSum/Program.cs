using System.Diagnostics.Metrics;

namespace MEArrays04FoldandSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] firstRow = new int[numbers.Length / 2];

            int[] secondRow = new int[numbers.Length / 2];

            int firstRowCounter = 0;

            for (int i = numbers.Length / 4 - 1; i >= 0; i--)
            {
                firstRow[firstRowCounter] = numbers[i];
                firstRowCounter++;
            }

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                firstRow[firstRowCounter] = numbers[numbers.Length - 1 - i];
                firstRowCounter++;
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                secondRow[i] = numbers[numbers.Length / 4 + i];
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int sum = 0;

                sum = firstRow[i] + secondRow[i];
                Console.Write($"{sum} ");
            }
        }
    }
}
