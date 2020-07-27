using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weapons = Console.ReadLine().Split("|").ToList();
            string[] command = Console.ReadLine().Split();
            List<string> resultEven = new List<string>();
            List<string> resultOdd = new List<string>();


            while (command[0] != "Done")
            {
                if (command[1] == "Left")
                {
                    int index = int.Parse(command[2]);
                    if (index - 1 >= 0 && index < weapons.Count)
                    {
                        string movable = weapons.ElementAt(index);
                        weapons.Insert(index - 1, movable);
                        weapons.RemoveAt(index + 1);
                    }
                }

                if (command[1] == "Right")
                {
                    int index = int.Parse(command[2]);
                    if (index >= 0 && index + 1 < weapons.Count)
                    {
                        string movable = weapons.ElementAt(index);
                        weapons.Insert(index + 2, movable);
                        weapons.RemoveAt(index);
                    }
                }

                if (command[1] == "Even")
                {
                    for (int i = 0; i < weapons.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            resultEven.Add(weapons[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", resultEven));
                }

                if (command[1] == "Odd")
                {
                    for (int i = 0; i < weapons.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            resultOdd.Add(weapons[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", resultOdd));

                }
                command = Console.ReadLine().Split();
            }
            Console.Write("You crafted ");
            Console.Write(string.Join("", weapons));
            Console.WriteLine("!");
        }
    }
}

