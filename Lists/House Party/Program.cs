using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string houser = command[0];

                if (command[2] == "going!")
                {
                    HouserIsGoing(names, houser);
                }

                if (command[2] == "not")
                {
                    HouserIsNotGoing(names, houser);
                }
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        static void HouserIsGoing(List<string> names, string houser)
        {
            if (names.Contains(houser))
            {
                Console.WriteLine($"{houser} is already in the list!");
            }
            else
            {
                names.Add(houser);
            }
        }

        static void HouserIsNotGoing(List<string> names, string houser)
        {
            if (names.Contains(houser))
            {
                names.Remove(houser);
            }
            else
            {
                Console.WriteLine($"{houser} is not in the list!");
            }

        }
    }
}
