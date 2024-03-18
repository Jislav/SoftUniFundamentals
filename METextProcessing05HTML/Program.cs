using System.Text;

namespace METextProcessing05HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();

            string content = Console.ReadLine();

            StringBuilder code = new StringBuilder();

            code.AppendLine("<h1>"); code.AppendLine($"\t{title}"); code.AppendLine("</h1>");

            code.AppendLine("<article>"); code.AppendLine($"\t{content}"); code.AppendLine("</article>");

            string comments = default;
            while ((comments = Console.ReadLine()) != "end of comments")
            {
                code.AppendLine("<div>");

                code.AppendLine($"\t{comments}");

                code.AppendLine("</div>");
            }
            Console.WriteLine(code.ToString());
        }
    }
}
