namespace Methods03Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfCalc = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (typeOfCalc)
            {
                case "add":
                    AddNumbers(a, b);
                    break;
                case "multiply":
                    MultiplyNumbers(a, b);
                    break;
                case "subtract":
                    SubtractNumbers(a, b);
                    break;
                case "divide":
                    DivideNumbers(a, b);
                    break;
            }
        }

        static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void DivideNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
