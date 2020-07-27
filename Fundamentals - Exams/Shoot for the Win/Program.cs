using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamRetake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            //int[] shots = new int[targets.Length]; //НОВ МАСИВ С РЕЗУЛТАТИТЕ
            int counter = 0;
            int currentTarget = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index >= targets.Length || index < 0) // проверка далие е възможен индекса
                {
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    currentTarget = targets[index];
                    //shots[index] = -1;
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (i != index && targets[i] > currentTarget && targets[i] != -1)
                        {
                            targets[i] = targets[i] - currentTarget;
                        }
                        else if (i != index && targets[i] <= currentTarget && targets[i] != -1)
                        {
                            targets[i] = targets[i] + currentTarget;
                        }
                    }
                    targets[index] = -1;
                    counter++;


                }
                command = Console.ReadLine();
                //targets = shots;
            }
            Console.Write($"Shot targets: {counter} -> ");
            Console.Write(string.Join(" ", targets));
        }
    }
}
