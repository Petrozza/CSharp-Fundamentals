using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] data = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                string color = data[1];
                int physics = int.Parse(data[2]);

                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs.Add(color, new Dictionary<string, int>());
                    if (!dwarfs[color].ContainsKey(name))
                    {
                        dwarfs[color].Add(name, physics);
                    }
                    else
                    {
                        dwarfs[color][name] = physics;
                    }
                }
                else
                {
                    if (!dwarfs[color].ContainsKey(name))
                    {
                        dwarfs[color].Add(name, physics);
                    }
                }

                if (dwarfs[color][name] < physics)
                {
                    dwarfs[color][name] = physics;
                }

                input = Console.ReadLine();
            }

            var sortedDwarfs = new Dictionary<string, int>();

            foreach (var color in dwarfs.OrderByDescending(x => x.Value.Count))
            {
                foreach (var item in color.Value)
                {
                    sortedDwarfs.Add($"({color.Key}) {item.Key} <->", item.Value);
                }
            }
            foreach (var pair in sortedDwarfs.OrderByDescending(v => v.Value))
            {
                Console.WriteLine($"{pair.Key}{pair.Value}");
            }
        }
    }
}
