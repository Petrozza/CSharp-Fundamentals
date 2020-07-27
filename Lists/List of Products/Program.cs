using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<string> products = new List<string>(4);

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            
            products.Sort();
           
            for (int j = 0; j < products.Count; j++)
            {
                Console.WriteLine($"{j + 1}.{products[j]}");
            }
        }
    }
}
