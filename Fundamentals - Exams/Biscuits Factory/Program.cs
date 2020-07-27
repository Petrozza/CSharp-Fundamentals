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
            int bizkitsPerDay = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int competeProduction30days = int.Parse(Console.ReadLine());
            double production30days = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    production30days += Math.Floor(bizkitsPerDay * countWorkers * 0.75);
                }
                else
                {
                    production30days += bizkitsPerDay * countWorkers;
                }
            }

            Console.WriteLine($"You have produced {production30days} biscuits for the past month.");

            if (production30days > competeProduction30days)
            {
                double diff = production30days - competeProduction30days;
                double percnt = diff / competeProduction30days * 100;
                Console.WriteLine($"You produce {percnt:f2} percent more biscuits.");
            }
            else
            {
                double diff = competeProduction30days - production30days;
                double percnt = diff / competeProduction30days * 100;
                Console.WriteLine($"You produce {percnt:f2} percent less biscuits.");
            }
        }
    }
}

