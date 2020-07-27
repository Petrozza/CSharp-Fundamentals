using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
           
            int bestGlobalLenght = 1;
            int minStartIndex = 0;
            int maxSumElements = 0;
            int bestCounter = 0;
            int[] bestDna = new int[n];

            int counter = 0;

            while (command != "Clone them!")
            {
                int[] dna = (command).Split('!', StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray();
                
                counter++;

                int lenght = 1;
                int maxLenght = 1;
                int startIndex = 0;
                int sumElements = 0;

                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == dna[i + 1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }

                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        startIndex = i;
                    }
                    sumElements += dna[i];

                }
                sumElements += dna[n - 1];

                if (maxLenght > bestGlobalLenght)
                {
                    bestGlobalLenght = maxLenght;
                    minStartIndex = startIndex;
                    maxSumElements = sumElements;
                    bestCounter = counter;
                    bestDna = dna.ToArray();
                }
                else if (maxLenght == bestGlobalLenght)
                {
                    if (startIndex < minStartIndex)
                    {
                        bestGlobalLenght = maxLenght;
                        minStartIndex = startIndex;
                        maxSumElements = sumElements;
                        bestCounter = counter;
                        bestDna = dna.ToArray();
                    }
                    else if (startIndex == minStartIndex)
                    {
                        if (sumElements > maxSumElements)
                        {
                            bestGlobalLenght = maxLenght;
                            minStartIndex = startIndex;
                            maxSumElements = sumElements;
                            bestCounter = counter;
                            bestDna = dna.ToArray();
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {maxSumElements}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }

}

