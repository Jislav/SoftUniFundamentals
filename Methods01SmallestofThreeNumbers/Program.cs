namespace Methods01SmallestofThreeNumbers
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

            int result = PrintSmallestNumber(numbers);
            Console.WriteLine(result);
        }

         static int PrintSmallestNumber(int[] numbers)
        {

            int smallestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (smallestNumber > numbers[i])
                {
                    smallestNumber = numbers[i];
                }
            }
            return smallestNumber;
        }
    }
}
