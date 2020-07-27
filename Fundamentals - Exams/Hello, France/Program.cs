using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal newPrice = 0m;
            List<decimal> newPrices = new List<decimal>();
            decimal currentProfit = 0m;
            decimal profit = 0m;
            decimal sumNewPrice = 0m;
            decimal price = 0m;

            for (int i = 0; i < items.Count; i++)
            {
                string[] deal = items[i].Split("->");
                string type = deal[0];
                price = decimal.Parse(deal[1]);

                if ((type == "Clothes" && price <= 50.00m) || (type == "Shoes" && price <= 35.00m) || (type == "Accessories" && price <= 20.50m))
                {
                    if (price > budget)
                    {
                        continue;
                    }
                    budget -= price;
                    newPrice = price * 1.4m;
                    newPrices.Add(price * 1.4m);
                    sumNewPrice += newPrice;
                    currentProfit = newPrice - price;
                    profit += currentProfit;
                }
                else
                {
                    continue;
                }
            }

            foreach (var item in newPrices)
            {
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:f2}");
            if (budget + sumNewPrice >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

        }
    }
}

