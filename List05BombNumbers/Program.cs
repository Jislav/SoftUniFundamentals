namespace List05BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombValues = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int specialNumber = bombValues[0];

            int bombPower = bombValues[1];
            while(numbers.Contains(specialNumber))
            {


                int specialNumberIndex = numbers.FindIndex(x => x == specialNumber);

                if (specialNumberIndex - bombPower < 0)
                {
                    for (int i = 0; i < bombPower - specialNumber; i++)
                    {
                        numbers.RemoveAt(0);
                    }
                }
                else
                {
                    numbers.RemoveRange(specialNumberIndex - bombPower, bombPower);
                }

                specialNumberIndex = numbers.FindIndex(x => x == specialNumber);

                if (specialNumberIndex + bombPower > numbers.Count - 1)
                {
                    var iterations = specialNumberIndex + bombPower - numbers.Count;

                    for (int i = 0; i < iterations; i++)
                    {
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
                else
                {
                    numbers.RemoveRange(specialNumberIndex, bombPower);
                }

                numbers.RemoveAt(specialNumberIndex);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
