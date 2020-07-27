using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var drivers = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string userName = input[1];
                

                if (command == "register")
                {
                    string plate = input[2];
                    if (!drivers.ContainsKey(userName))
                    {
                        drivers.Add(userName, plate);
                        Console.WriteLine($"{userName} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }

                else if (command == "unregister")
                {
                    if (!drivers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        drivers.Remove(userName);
                    }
                }
            }
            foreach (var kvp in drivers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
