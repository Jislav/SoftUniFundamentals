namespace Methods09GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (type == "string")
            {
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(a), char.Parse(b)));
            }
            else
            {
                Console.WriteLine(GetMax(int.Parse(a), int.Parse(b)));
            }
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);

            if (result > 0)
            {
                return a;
            }

            return b;
        }
    }
}
