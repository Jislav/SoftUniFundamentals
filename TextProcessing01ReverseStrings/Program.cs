namespace TextProcessing01ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = default;

            while((line = Console.ReadLine()) != "end")
            {
                char[] lineReversed = line.Reverse().ToArray();
                Console.WriteLine($"{line} = {string.Join("", lineReversed)}");
            }
        }
    }
}
