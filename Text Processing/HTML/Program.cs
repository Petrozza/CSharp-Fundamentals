using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            Console.WriteLine($"<h1>");
            Console.WriteLine($"    {line1}");
            Console.WriteLine($"</h1>");
            Console.WriteLine($"<article>");
            Console.WriteLine($"    {line2}");
            Console.WriteLine($"</article>");


            while (true)
            {
                string line3 = Console.ReadLine();
                if (line3 == "end of comments")
                {
                    break;
                }
                Console.WriteLine($"<div>");
                Console.WriteLine($"    {line3}");
                Console.WriteLine($"</div>");

            }
        }
    }
}
