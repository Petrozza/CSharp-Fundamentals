using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{(decimal)arr[i]} => {(decimal)Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
