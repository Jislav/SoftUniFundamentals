namespace Arrays03RoundingNumbers;
using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {

        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        int[] roundedNumber =  new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            roundedNumber[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
        }

        for (int j = 0; j < numbers.Length; j++)
        {
            Console.WriteLine($"{numbers[j]} => {roundedNumber[j]}");
        }
    }
}


