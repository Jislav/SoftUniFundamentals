using System.Text;

namespace TextProcessing05MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                int carry = 0;

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int result = (number[i] - '0') * multiplier + carry;
                    sb.Append(result % 10);
                    carry = result / 10;
                }
                if (carry != 0)
                {
                    sb.Append(carry);
                }
                char[] newNumber = sb.ToString().Reverse().ToArray();
                Console.WriteLine(newNumber);
            }
        }
    }
}
