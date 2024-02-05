namespace Methods05AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int firstOperation = SumOfFirstAndSecondNumber(numbers);
            int finalResult = SubtractThirdFromTotal(firstOperation, numbers[2]);
            Console.WriteLine(finalResult);
        }

         static int SubtractThirdFromTotal(int sum ,int thirdNumber)
        {
            int result = sum - thirdNumber;

            return result;
        }

        static int SumOfFirstAndSecondNumber(int[] numbers)
        {
            int result = numbers[0] + numbers[1];

            return result;
        }
    }
}
