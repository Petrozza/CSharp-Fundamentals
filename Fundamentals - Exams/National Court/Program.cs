using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int empl1 = int.Parse(Console.ReadLine());
            int empl2 = int.Parse(Console.ReadLine());
            int empl3 = int.Parse(Console.ReadLine());
            int waitngPeople = int.Parse(Console.ReadLine());
            int pplforOneHour = empl1 + empl2 + empl3;

            int hours = 0;
            int sumPeople = 0;

            while (sumPeople < waitngPeople)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                sumPeople += pplforOneHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}