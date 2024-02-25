namespace ObjectsAndClasses02Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string[] tokens = line.Split(", ");

            string title = tokens[0];
            string content = tokens[1];
            string author = tokens[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands ; i++)
            {

                string command = Console.ReadLine();
                string[] commandTokens = command.Split(":");
                command = commandTokens[0];
                switch(command)
                {
                    case "Edit":
                        article.Edit(article, commandTokens[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(article, commandTokens[1]);
                        break;
                    case "Rename":
                       article.Rename(article, commandTokens[1]);
                        break;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }

        //public void Rename(Article article, string newName)
        //{
        //    article.Author = newName;
        //}

        //public void ChangeAuthor(Article article, string author)
        //{
        //    article.Author = author;
        //}

        //public void Edit(Article article, string edit)
        //{
        //    article.Title = edit;
        //}
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
       
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Rename(Article article, string newName)
        {
            article.Title = newName.Trim();
        }
        public void ChangeAuthor(Article article, string author)
        {
            article.Author = author.Trim();
        }
        public void Edit(Article article, string edit)
        {
            article.Content = edit.Trim();
        }
    }
}
