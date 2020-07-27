using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];
               
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    field[currentIndex] = 1;
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladyBugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLenght = int.Parse(elements[2]);

                if (ladyBugIndex < 0 || ladyBugIndex > field.Length -1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (direction == "right")
                {
                    int landingIndex = ladyBugIndex + flyLenght;

                    if (landingIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landingIndex] == 1)
                    {
                        while (field[landingIndex] == 1)
                        {
                            landingIndex += flyLenght;
                            if (landingIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (landingIndex >= 0 && landingIndex <= field.Length - 1)
                    {
                       field[landingIndex] = 1;
                    }
                }
                
                else if (direction == "left")
                {
                    int landingIndex = ladyBugIndex - flyLenght;
                    
                    if (landingIndex < 0)
                    {
                        continue;
                    }

                    if (field[landingIndex] == 1)
                    {
                        while (field[landingIndex] == 1)
                        {
                            landingIndex -= flyLenght;
                            if (landingIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landingIndex >= 0 && landingIndex <= field.Length -1)
                    {
                        field[landingIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
