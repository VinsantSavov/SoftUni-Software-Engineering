using System;
using System.Linq;

namespace _2.Articles
{
    class Program
    {
        class Article
        {
            public Article(string title,string content,string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                Title = newTitle;
            }
        }

        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(", ").ToArray();
            string title = line[0];
            string content = line[1];
            string author = line[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }

            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

        }
    }
}
