using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {


                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }

                string[] command = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = command[0];
                string color = command[1];
                int physics = int.Parse(command[2]);

                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs.Add(color, new Dictionary<string, int>());
                    dwarfs[color][name] = physics;
                }

                if (!dwarfs[color].ContainsKey(name))
                {
                    dwarfs[color].Add(name, physics);
                }
                //else
                //{
                    if (dwarfs[color][name] < physics)
                    {
                        dwarfs[color][name] = physics;
                    }
                    //dwarfs[color][name] = physics;
                //}
            }


            var sortedDwarfs = new Dictionary<string, int>();
            foreach (var color in dwarfs.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in color.Value)
                {
                    sortedDwarfs.Add($"({color.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
