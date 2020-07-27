using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "buy")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!products.ContainsKey(product))
                {

                    products.Add(product, new List<double> { price, quantity });
                }
                else
                {
                    List<double> list = products[product];
                    list[0] = price;
                    list[1] += quantity;
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var drink in products)
            {
                double totalprice = drink.Value[0] * drink.Value[1];
                Console.WriteLine($"{drink.Key} -> {totalprice:f2}");
            }
        }
    }
}

