namespace Arrays06EvenandOddSubtraction;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            foreach (int currentNumber in numbers)
            {
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }

