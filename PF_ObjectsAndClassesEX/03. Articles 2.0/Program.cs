using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> articleList = Console.ReadLine()
                .Split(", ")
                .ToList();

                string title = articleList[0];
                string content = articleList[1];
                string author = articleList[2];

                Article article = new Article();
                article.Title = title;
                article.Content = content;
                article.Author = author;

                listOfArticles.Add(article);
            }

            foreach (Article article in listOfArticles)
            {
                Console.WriteLine(article.Title + " - " + article.Content + ": " + article.Author);
            }
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string ToCoolString()
        {
            string returnString = $"{Title} - {Content}: {Author}";
            return returnString;
        }
    }
}
