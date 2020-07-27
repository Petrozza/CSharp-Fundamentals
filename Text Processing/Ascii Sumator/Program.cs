using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two =  char.Parse(Console.ReadLine());
            string shit = Console.ReadLine();
            
            int firstNum = one + 0;
            int secondtNum = two + 0;
            int sum = 0;

            for (int i = 0; i < shit.Length; i++)
            {
                if (shit[i]> one && shit[i] < two)
                {
                    sum += shit[i]; 

                }
            }
            Console.WriteLine(sum);
        }
    }
}
