namespace ExamPrep03Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> topNumbers = new List<int>();

            double average = (double)numbers.Sum() / (double)numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    topNumbers.Add(numbers[i]);
                }
            }

            topNumbers.Sort();
            topNumbers.Reverse();

            if(topNumbers.Count == 0 )
            {
                Console.WriteLine("No");
            }
            else
            {
                List<int> topFiveNumbers = topNumbers.Take(5).ToList();
                Console.WriteLine(string.Join(" ", topFiveNumbers));
            }
        }
    }
}
