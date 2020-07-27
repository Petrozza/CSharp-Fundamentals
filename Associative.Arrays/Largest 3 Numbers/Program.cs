using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> sorted = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
