namespace Arrays04ReverseArrayofStrings;
using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split().ToArray();
        string[] reverse = new string[input.Length];

        for (int i = 0; i < reverse.Length; i++)
        {
            reverse[i] = input[input.Length - 1 - i];
        }

        for (int j = 0; j < reverse.Length; j++)
        {
            Console.Write($"{reverse[j]} ");
        }
    }
}

