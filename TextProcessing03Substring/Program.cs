namespace TextProcessing03Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string line = Console.ReadLine();

            while(line.Contains(filter))
            {
                int index = line.IndexOf(filter);

                line = line.Remove(index, filter.Length);
            }
            Console.WriteLine(line);
        }
    }
}
