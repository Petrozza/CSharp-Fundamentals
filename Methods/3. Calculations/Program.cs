using System;
using System.Security.Cryptography.X509Certificates;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCalculation(Console.ReadLine(),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())); 
        }

        static void PrintCalculation(string opertion, int x, int y)
        {
            switch (opertion)
            {
                case "add":
                    Console.WriteLine(x + y);
                    break;
                case "multiply":
                    Console.WriteLine(x * y);
                    break;
                case "subtract":
                    Console.WriteLine(x - y);
                    break;
                case "divide":
                    if (y != 0)
                    {
                        Console.WriteLine(x / y);
                    }
                    break;
            }
        } 
    }
}
