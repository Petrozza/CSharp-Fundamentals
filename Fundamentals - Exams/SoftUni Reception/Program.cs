using System;

namespace Softuni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeEff1 = int.Parse(Console.ReadLine());
            int employeeEff2 = int.Parse(Console.ReadLine());
            int employeeEff3 = int.Parse(Console.ReadLine());
            ;
            int students = int.Parse(Console.ReadLine());
            int studentsPerHour = employeeEff1 + employeeEff2 + employeeEff3;
            int countHours = 0;
            int processedStudents = 0;
            while (students > 0)
            {
                processedStudents += studentsPerHour;
                countHours++;
                if (countHours % 4 == 0)
                {
                    processedStudents -= studentsPerHour;
                    continue;
                }
                students -= studentsPerHour;
                if (students <= 0)
                {
                    Console.WriteLine($"Time needed: {countHours}h.");
                    return;
                }
            }
            Console.WriteLine($"Time needed: {0}h.");
        }
    }

}

