using System.Text;

namespace Methods10TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintTopNumber(number));
           
        }

        static string PrintTopNumber(int number)
        {
            StringBuilder topNumbers = new StringBuilder();


            for (int i = 0; i <= number; i++)
            {
                bool hasOddNum = false;
                int sum = 0;
                int currentNumber = i;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                  
                    sum += currentNumber % 10;

                    if (currentNumber % 2 != 0) 
                    {
                        hasOddNum = true;
                    }
                    currentNumber /= 10;
                }

                if (sum % 8 == 0 && hasOddNum)
                {
                    topNumbers.AppendLine(i.ToString());
                }
            }
            return topNumbers.ToString();
        }
    }
}
