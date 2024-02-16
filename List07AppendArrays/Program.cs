namespace List07AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> result = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] arr = arrays[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                result.AddRange(arr);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
