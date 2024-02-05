namespace _08MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = MathPower(a, b);

            Console.WriteLine(result);
        }

        static double MathPower(double n, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
