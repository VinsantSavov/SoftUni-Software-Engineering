using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Articles
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            string text = $"{Title} - {Content}: {Author}";
            return text;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split(", ").ToList();
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ").ToArray();
                string command = commands[0];
                string property = commands[1];

                if(command == "Edit")
                {
                    article.Edit(property);
                }
                else if(command == "ChangeAuthor")
                {
                    article.ChangeAuthor(property);
                }
                else if(command == "Rename")
                {
                    article.Rename(property);
                }
            }

            Console.WriteLine(article);
        }
    }
}
