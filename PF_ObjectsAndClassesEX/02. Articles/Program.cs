using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string title = articleList[0];
            string content = articleList[1];
            string author = articleList[2];

            Article arthicle = new Article();
            arthicle.Title = title;
            arthicle.Content = content;
            arthicle.Author = author;

            int numCmds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCmds; i++)
            {
                string cmd = Console.ReadLine();
                string[] cmdArr = cmd.Split(": ");

                if (cmdArr[0] == "Edit")
                {
                    arthicle.Content = arthicle.Edit(cmdArr[1]);
                }
                else if (cmdArr[0] == "ChangeAuthor")
                {
                    arthicle.Author = arthicle.ChangeAuthor(cmdArr[1]);
                }
                else if (cmdArr[0] == "Rename")
                {
                    arthicle.Title = arthicle.Rename(cmdArr[1]);
                }
            }

            Console.WriteLine(arthicle.ToString());
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string word)
        {
            Content = word;
            return Content;
        }

        public string ChangeAuthor(string word)
        {
            Author = word;
            return Author;
        }

        public string Rename(string word)
        {
            Title = word;
            return Title;
        }

        public string ToString()
        {
            string returnString = $"{Title} - {Content}: {Author}";
            return returnString;
        }
    }
}
