using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Transactions;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(", ");

                Article article = new Article();
                
                article.Title = data[0];
                article.Content = data[1];
                article.Author = data[2];

                articles.Add(article);
            }

            string criteria = Console.ReadLine();


            if (criteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(b => b.Content).ToList();
            }
            else
            {
               articles = articles.OrderBy(c => c.Author).ToList();
            }

            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }

        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    } 
}
