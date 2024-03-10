namespace TextProcessing03ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine()
                .Split("\\")
                .ToArray();

            string[] tokens = filePath.Last().Split(".");

            string fileName = tokens[0];
            string fileExtenson = tokens[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtenson}");
        }
    }
}
