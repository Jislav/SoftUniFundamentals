using System.Text;

namespace TextProcessing06ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();

            for (int i = 0; i < text.Length - 1; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(text[i]);
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (sb.Length > 1)
                {
                    text = text.Replace(sb.ToString(), text[i].ToString());
                }
            }
            Console.WriteLine(text);
        }
    }
}
