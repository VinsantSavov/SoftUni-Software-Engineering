using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Articles2._0
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
            List<Article> articles = new List<Article>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if(criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if(criteria == "content")
            {
                articles = articles.OrderBy(c => c.Content).ToList();
            }
            else if(criteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
