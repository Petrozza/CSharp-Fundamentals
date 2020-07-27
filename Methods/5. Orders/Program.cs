using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            PrintOrderPrice(product, price);
        }

        static void PrintOrderPrice(string prod, double quan)
        {
            switch (prod)
            {
                case "coffee":
                    Console.WriteLine($"{quan * 1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quan * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quan * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quan * 2.00:f2}");
                    break;
            }

        }
    }
}
