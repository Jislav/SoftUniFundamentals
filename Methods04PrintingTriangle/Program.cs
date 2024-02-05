namespace Methods04PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTriangle(input);
        }

        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                TriangleRow(i);
            }

            for (int i = number - 1; i >= 1; i--)
            {
                TriangleRow(i);
            }
        }

        static void TriangleRow(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }

            Console.WriteLine();
        }
    }
}
