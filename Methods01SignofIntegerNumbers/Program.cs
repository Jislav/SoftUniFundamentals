namespace Methods01SignofIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            CheckNumber(input);
        }

        private static void CheckNumber(int input)
        {
            if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive. ");
            }
            else if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {input} is zero. ");
            }
        }
    }
}
