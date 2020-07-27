using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                Student student = new Student();

                student.FirstName = info[0];
                student.SecondName = info[1];
                student.Grade = double.Parse(info[2]);

                students.Add(student);
            }
            students = students.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
    }
}
