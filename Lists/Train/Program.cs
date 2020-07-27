using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            if (maxCapacity <= 0)
            {
                return;
            }
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                
                if (command.Length == 2)
                {
                    AddWagons(wagons, command);
                }

                if (command.Length == 1)
                {
                    int passangers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxCapacity)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        static void AddWagons(List<int> wagons, string[] command)
        {
            int newWagon = int.Parse(command[1]);
            wagons.Add(newWagon);
        }

        static void AddPassangers(List<int> wagons, string[] command, int maxCapacity)
        {
            int passangers = int.Parse(command[0]);
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passangers <= maxCapacity)
                {
                    wagons[i] += passangers;
                    return;
                }
            }


        }
    }
}
