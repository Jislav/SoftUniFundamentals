namespace Arrays05SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int totalSum = 0;
            foreach (int currentNumber in numbers)
            {
                if (currentNumber % 2 == 0)
                {
                    totalSum += currentNumber;
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
