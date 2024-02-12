using System.Numerics;

namespace Methods08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            BigInteger aFactorial = AFactorial(Math.Abs(a));
            BigInteger bFactorial = BFactorial(Math.Abs(b));

            double result = FactorialDivision(aFactorial, bFactorial);
            Console.WriteLine($"{result:f2}");
        }

         static double FactorialDivision(BigInteger a, BigInteger b)
         {
             double result = (double)a / (double)b;

             return result;
         }

        static BigInteger BFactorial(int b)
        {
            BigInteger result = 1;

            for (int i = 1; i <= b; i++)
            {
                result *= i;
            }

            return result;
        }

        static BigInteger AFactorial(int a)
         {
             BigInteger result = 1;

             for (int i = 1; i <= a; i++)
             {
                 result *= i;
             }
             
             return result;
         }
        
    }
}
