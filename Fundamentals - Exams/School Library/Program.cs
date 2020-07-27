using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> books = Console.ReadLine().Split("&").ToList();
            string[] command = Console.ReadLine().Split(" | ").ToArray();
            while (command[0] != "Done")
            {
                switch (command[0])
                {
                    case "Add Book":
                        if (!books.Contains(command[1]))
                        {
                            books.Insert(0, command[1]);
                        }
                        break;

                    case "Take Book":
                        if (books.Contains(command[1]))
                        {
                            books.Remove(command[1]);
                        }
                        break;

                    case "Swap Books":
                        string book1 = command[1];
                        string book2 = command[2];
                        if (books.Contains(book1) && books.Contains(book2))
                        {
                            int book1Index = books.IndexOf(book1);
                            int book2Index = books.IndexOf(book2);
                            if (book1Index < book2Index)
                            {
                                books.Insert(book2Index, book1);
                                books.Insert(book1Index, book2);
                                books.RemoveAt(book1Index + 1);
                                books.RemoveAt(book2Index + 1);
                            }
                        }
                        break;

                    case "Insert Book":
                        books.Add(command[1]);
                        break;

                    case "Check Book":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < books.Count)
                        {
                            int index = int.Parse(command[1]);
                            Console.WriteLine(books[index]);
                        }
                        break;
                }
                command = Console.ReadLine().Split(" | ").ToArray();
            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}

