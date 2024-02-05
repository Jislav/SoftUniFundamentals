using static System.Console;

namespace Methods10MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            GetSumOfEvenDigits(number);
            GetSumOfOddDigits(number);
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

        }

        static int GetSumOfEvenDigits(int number)
        {
            int result = 0;

            for (int i = number; number > 0; number /= 10)
            {
                int currentNumber = number % 10;
                
                if(currentNumber % 2 == 0)
                {
                    result += currentNumber;
                }
            }

            return result;
        }
        static int GetSumOfOddDigits(int number)
        {
            int result = 0;

            for (int i = number; number > 0; number /= 10)
            {
                int currentNumber = number % 10;

                if (currentNumber % 2 != 0)
                {
                    result += currentNumber;
                }
            }
            return result;
        }
    }
}
