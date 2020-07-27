using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            var orderd = new Dictionary<string, double>();
            foreach (var student in students)
            {
                orderd.Add(student.Key, student.Value.Average());
            }
            foreach (var item in orderd.Where(x => x.Value >= 4.50)
                    .OrderByDescending(y => y.Value).ToDictionary(x => x.Key, y => y.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
