using System;
using System.Collections.Generic;
using System.Linq;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Travel")
                {
                    break;
                }
                string[] command = input.Split(':');

                if (command[0].Contains("Add"))
                {
                    int index = int.Parse(command[1]);
                    string str = command[2];
                    if (index >= 0 && index < stops.Length) //or index <= stops.Length ??
                    {
                        stops = stops.Insert(index, str);
                    }
                }

                else if (command[0].Contains("Remove"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex <= endIndex && startIndex < stops.Length && endIndex < stops.Length) 
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1); //check length
                    }
                }

                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];
                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                }
                Console.WriteLine(stops);

            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
        static bool IsValid(int index, string stops)
        {
            if (index >= 0 && index < stops.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
