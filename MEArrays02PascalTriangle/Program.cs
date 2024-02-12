namespace MEArrays02PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] previousRow = { 1 };
            Console.WriteLine(string.Join("" ,previousRow));

            for (int i = 0; i < rows - 1; i++)
            {
                int[] nextRow = new int[i + 2];

                for (int j = 0; j < nextRow.Length; j++)
                {
                    if (j == 0 || j == nextRow.Length - 1)
                    {
                        nextRow[j] = 1;
                    }
                    else
                    {
                        nextRow[j] = previousRow[j - 1] + previousRow[j];
                    }
                }

                previousRow = nextRow;
                Console.WriteLine(string.Join(" ",nextRow));
            }
        }
    }
}