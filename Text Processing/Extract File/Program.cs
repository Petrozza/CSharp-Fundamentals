using System;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split(@"\").ToArray();
            string filename = path[path.Length - 1];
            string[] file = filename.Split(".");
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
