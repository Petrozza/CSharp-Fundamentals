using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string material = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            var resources = new Dictionary<string, int>();
            while (material != "stop")
            {

                if (resources.ContainsKey(material))
                {
                    resources[material] += quantity;
                }
                else
                {
                    resources.Add(material, quantity);
                }

                material = Console.ReadLine();
                if (material == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

