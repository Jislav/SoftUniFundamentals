namespace MEArrays01EncryptSortandPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            int[] values = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string name = Console.ReadLine();

                int sum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U')
                    {
                        sum += name[j] * name.Length;
                    }
                    else
                    {
                        sum += name[j] / name.Length;
                    }
                }
                values[i] = sum;
            }

            int[] result = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int lowestNumber = int.MaxValue;
                int lowestNumberIndex = 0;

                for (int j = 0; j < values.Length; j++)
                {
                    if (lowestNumber > values[j])
                    {
                        lowestNumber = values[j];
                        lowestNumberIndex = j;
                    }
                }

                result[i] = lowestNumber;
                values[lowestNumberIndex] = int.MaxValue;
            }


            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}