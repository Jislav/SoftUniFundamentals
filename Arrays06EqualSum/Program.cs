namespace Arrays06EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool thereIsEqualSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        leftSum += arr[j];
                    }
                }

                if (i == arr.Length - 1)
                {
                    rightSum = 0;
                }
                else
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        rightSum += arr[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    thereIsEqualSum = true;
                    Console.WriteLine($"{i} ");
                }
            }

            if (thereIsEqualSum == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}