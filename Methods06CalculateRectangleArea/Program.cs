namespace Methods06CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int area = PrintRectangleArea(a, b);
            Console.WriteLine(area);
        }

        static int PrintRectangleArea(int a ,int b)
        {
            return a * b;
        }
    }
}
