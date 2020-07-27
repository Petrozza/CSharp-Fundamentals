using System;
using System.Data;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "int")
            {
                int value = int.Parse(Console.ReadLine());
                PrintResult(value);
            }

            if (command == "real")
            {
                double value = double.Parse(Console.ReadLine());
                PrintResult(value);
            }

            if (command == "string")
            {
                string value = Console.ReadLine();
                PrintResult(value);
            }
        }

        static void PrintResult(int value)
        {
            
            Console.WriteLine(value * 2);
        }

        static void PrintResult(double value)
        {
        
        Console.WriteLine($"{value * 1.5:f2}");
        }

        static void PrintResult(string value)
        {
            
            Console.WriteLine($"${value}$");
        }
    }


}
