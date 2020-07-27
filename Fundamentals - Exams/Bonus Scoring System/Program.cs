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
            int countOfStudents = int.Parse(Console.ReadLine()); //0-50
            int countOfLectures = int.Parse(Console.ReadLine()); //0-100
            int initialBonus = int.Parse(Console.ReadLine()); // 0-100

            double totalBonus = 0;
            double maxBonus = 0;
            int maxAttend = 0;
            int attend = 0;

            for (int stud = 1; stud <= countOfStudents; stud++)
            {
                attend = int.Parse(Console.ReadLine());
                totalBonus = attend * 1.0 / countOfLectures * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttend = attend;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttend} lectures.");

        }


    }
}
