using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initialDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> currentSet = new List<int>();
            foreach (var item in initialDrumSet)
            {
                currentSet.Add(item);
            }

            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int currentPower = int.Parse(command);
                for (int i = 0; i < currentSet.Count; i++)
                {
                    
                    if ((currentSet[i] - currentPower) <= 0)
                    {
                        if (savings >= initialDrumSet[i] * 3)
                        {
                            savings -= initialDrumSet[i] * 3;
                            currentSet[i] = initialDrumSet[i];
                        }
                        else
                        {
                            currentSet.RemoveAt(i);
                            initialDrumSet.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        currentSet[i] -= currentPower;
                    }

                    
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", currentSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
