using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MaxSnow = 0;
            int MaxTime = 0;
            int MaxQuality = 0;
            BigInteger MaxValue= 0;

            for (int i = 1; i <= n; i++)
            {
                 int snow = int.Parse(Console.ReadLine());
                 int time = int.Parse(Console.ReadLine());
                 int quality = int.Parse(Console.ReadLine());
                 BigInteger value = BigInteger.Pow(snow / time, quality);

                if (value > MaxValue)
                {
                    MaxValue = value;
                    MaxSnow = snow;
                    MaxTime = time;
                    MaxQuality = quality;
                }
            }
            Console.WriteLine($"{MaxSnow} : {MaxTime} = {MaxValue} ({MaxQuality})");
        }
    }
}
