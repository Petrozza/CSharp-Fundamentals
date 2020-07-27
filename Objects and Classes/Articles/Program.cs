using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(", ");

            int n = int.Parse(Console.ReadLine());

            Article article = new Article
            {
                Title = command[0],
                Content = command[1],
                Author = command[2]
            };

            for (int i = 0; i < n; i++)
            {
                List<string> newInput = Console.ReadLine().Split(':').Select(s => s.Trim()).ToList();

                if (newInput[0] == "Edit")
                {
                    article.Content = newInput[1];
                }
                else if (newInput[0] == "ChangeAuthor")
                {
                    article.Author = newInput[1];
                }
                else if (newInput[0] == "Rename")
                {
                    article.Title = newInput[1];
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }


    }

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}
