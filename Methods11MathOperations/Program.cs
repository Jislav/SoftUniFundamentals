namespace Methods11MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, @operator, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculate(double a, string @operator, double b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
