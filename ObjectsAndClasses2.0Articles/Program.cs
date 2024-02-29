namespace ObjectsAndClasses2._0Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());


            List<Article> articles = new List<Article>();


            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();

                string[] tokens = line.Split(", ");

                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);

                article.Title = title;
                article.Content = content;
                article.Author = author;

                articles.Add(article);
            }

            foreach (Article currentArticle in articles)
            {
                Console.WriteLine($"{currentArticle.Title} - {currentArticle.Content}: {currentArticle.Author}");
            }
        }
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
    }
}

