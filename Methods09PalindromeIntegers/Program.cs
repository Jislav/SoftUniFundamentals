using System.Text;

namespace Methods09PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {

                Console.WriteLine(PalidromeChecker(number));
                number = Console.ReadLine();
            }
        }

         static string PalidromeChecker(string number)
         {
            StringBuilder numberReversed = new StringBuilder();

            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                numberReversed.Append(number[i]);
            }

            if (numberReversed.ToString() == number)
            {
                return true.ToString().ToLower();
            }

            else
            {
                return false.ToString().ToLower();
            }
         }
    }
}
