using System.Text;

namespace METextProcessing01ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, string> information = new Dictionary<string, string>();

            for (int i = 0; i < lines; i++)
            {
                string line = Console.ReadLine();
                string name = line.Substring(line.IndexOf('@') + 1, line.IndexOf('|') - line.IndexOf('@') - 1);
                string age = line.Substring(line.IndexOf('#') + 1, line.IndexOf('*') - line.IndexOf('#') - 1);
                information.Add(name, age);
            }
            foreach(KeyValuePair<string, string> kvp in information)
            {
                Console.WriteLine($"{kvp.Key} is {kvp.Value} years old.");
            }
        }
    }
}
