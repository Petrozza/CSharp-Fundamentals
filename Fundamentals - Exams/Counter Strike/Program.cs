using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int countWins = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWins} won battles and {initialEnergy} energy");
                    return;
                }
                else
                {
                    initialEnergy -= distance;
                    countWins++;
                }

                if (countWins % 3 == 0)
                {
                    initialEnergy += countWins;

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {countWins}. Energy left: {initialEnergy}");
        }
    }
}
