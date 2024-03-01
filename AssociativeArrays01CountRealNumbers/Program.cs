namespace AssociativeArrays01CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount[numbers[i]]++;
                }
                else
                {
                    numbersCount.Add(numbers[i], 1);
                }
            }
            foreach(KeyValuePair<double, int> number in numbersCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
