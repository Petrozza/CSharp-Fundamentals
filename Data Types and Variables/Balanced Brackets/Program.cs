using System;
using System.Runtime.InteropServices;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long openBra = 0;
            long closedBra = 0;
            for (int i = 1; i <= n; i++)
            {
                string row = Console.ReadLine();
                if (row == "(" )
                {
                    openBra++;
                }
                else if( row == ")")
                {
                    closedBra++;
                }
                if (closedBra > openBra)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

            }
            if (openBra == closedBra)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
