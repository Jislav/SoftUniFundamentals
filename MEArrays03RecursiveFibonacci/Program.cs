using System.Numerics;

namespace MEArrays03RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] memory = new int[number];

            BigInteger result = GetFibonacci(number);
            result = GetFibonacci(number - 1) + GetFibonacci(number - 2);
            Console.WriteLine(result);
        }

         static int GetFibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                 return GetFibonacci(number - 1) + GetFibonacci(number - 2);
            }
        }
    }
}
