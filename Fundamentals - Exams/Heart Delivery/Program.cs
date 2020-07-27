using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbor = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int lastPosition = 0;
            int current = 0;
            int counter = 0;

            while (command[0] != "Love!")
            {
                int jump = int.Parse(command[1]);
                current += jump;

                if (current >= neighbor.Length)
                {
                    current = 0;
                }

                if (neighbor[current] == 0)
                {
                    Console.WriteLine($"Place {current} already had Valentine's day.");
                }
                else
                {
                    neighbor[current] -= 2;

                    if (neighbor[current] <= 0)
                    {
                        Console.WriteLine($"Place {current} has Valentine's day.");
                        neighbor[current] = 0;
                        counter++;
                    }
                }

                lastPosition = current;
                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            if (neighbor.Length - counter == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighbor.Length - counter} places.");
            }
        }
    }
}