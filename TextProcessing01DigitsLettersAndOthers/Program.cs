namespace TextProcessing05DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] letters = text.Where(x => char.IsLetter(x)).ToArray();
            char[] numbers = text.Where(x => char.IsDigit(x)).ToArray();
            char[] other = text.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            Console.WriteLine(string.Join("", numbers));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", other));
        }
    }
}
