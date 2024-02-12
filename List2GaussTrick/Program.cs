namespace List2GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            if (numbers.Count % 2 != 0)
            {
                for (int i = 0; i < numbers.Count / 2 + 1; i++)
                {
                    int sum = 0;
                    if (i == numbers.Count / 2)
                    {
                        sum = numbers[i];
                    }
                    else
                    {
                        sum += numbers[i] + numbers[numbers.Count - 1 - i];
                    }
                    Console.Write($"{sum} ");
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    int sum = 0;
                    sum += numbers[i] + numbers[numbers.Count - 1 - i];
                    Console.Write($"{sum} ");
                }
            }

        }
    }
}
