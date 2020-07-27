using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ").ToArray();
            var companies = new SortedDictionary<string, List<string>>();

            while (input[0] != "End")
            {
                string companyName = input[0];
                string id = input[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(id);
                }
                else
                {
                    if (!companies[companyName].Contains(id))
                    {
                        companies[companyName].Add(id);
                    }
                }
                input = Console.ReadLine().Split(" -> ").ToArray();

            }
            foreach (var pair in companies)
            {
                Console.WriteLine(pair.Key);

                foreach (var id in pair.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
