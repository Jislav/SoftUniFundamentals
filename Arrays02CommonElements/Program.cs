namespace Arrays02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split()
                .ToArray();
            string[] secondArray = Console.ReadLine()
                .Split()
                .ToArray();

            string[] equalElements = new string[Math.Max(firstArray.Length, secondArray.Length)];

            int index = 0;
            if (firstArray.Length > secondArray.Length || firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    for (int j = 0; j < firstArray.Length; j++)
                    {
                        if (secondArray[i] == firstArray[j])
                        {
                            equalElements[index] = secondArray[i];
                            index++;
                        }
                    }
                }
            }
            else if(firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    for (int j = 0; j < secondArray.Length; j++)
                    {
                        if (secondArray[j] == firstArray[i])
                        {
                            equalElements[index] = secondArray[i];
                            index++;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", equalElements));
        }
    }
}
