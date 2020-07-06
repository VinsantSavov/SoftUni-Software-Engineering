using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Articles2._0
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

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {
            int numArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string order = Console.ReadLine();

            if(order == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if(order == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if(order == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (var kvp in articles)
            {
                Console.WriteLine($"{kvp.Title} - {kvp.Content}: {kvp.Author}");
            }
        }
    }
}
