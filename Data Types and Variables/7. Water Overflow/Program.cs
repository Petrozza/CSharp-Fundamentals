using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sumLitters = 0;

            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumLitters += liters;
                    if (sumLitters > 255)
                    {
                        Console.WriteLine("Insufficient capacity!");
                        sumLitters -= liters;
                        continue;
                    }
                }

            }
            Console.WriteLine(sumLitters);
        }
    }
}
