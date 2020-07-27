using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {

                switch (command[0])
                {
                    case "Shoot":
                        ShotByIndex(targets, command);
                        break;
                    case "Add":
                        InsertATarget(targets, command);
                        break;
                    case "Strike":
                        RemoveTheTarget(targets, command);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join("|", targets));
        }

        static List<int> ShotByIndex(List<int> result, string[] commant)
        {
            int index = int.Parse(commant[1]);
            int power = int.Parse(commant[2]);
            if (index >= 0 && index < result.Count)
            {
                result[index] -= power;
                if (result[index] <= 0)
                {
                    result.RemoveAt(index);
                }
            }
            return result;
        }

        static List<int> InsertATarget(List<int> result, string[] commant)
        {
            int index = int.Parse(commant[1]);
            int value = int.Parse(commant[2]);
            if (index >= 0 && index < result.Count)
            {
                result.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
            return result;
        }

        static List<int> RemoveTheTarget(List<int> result, string[] commant)
        {
            int index = int.Parse(commant[1]);
            int radius = int.Parse(commant[2]);
            if (index - radius >= 0 && index + radius < result.Count)
            {
                result.RemoveRange(index - radius, radius * 2 + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
            return result;
        }
    }
}
