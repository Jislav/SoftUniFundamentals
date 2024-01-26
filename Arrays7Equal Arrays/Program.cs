namespace Arrays7Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputFirstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] intputSecondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int totalSum = 0;
            int differentIndex = 0;
            bool arraysAreIndentical = true;

            for (int i = 0; i < inputFirstArray.Length; i++)
            {
                if (inputFirstArray[i] == intputSecondArray[i])
                {
                    totalSum += inputFirstArray[i];
                }
                else
                {
                    differentIndex = i;
                    arraysAreIndentical = false;
                    break;
                }

            }
            if (arraysAreIndentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differentIndex} index");
            }
        }
    }
}
