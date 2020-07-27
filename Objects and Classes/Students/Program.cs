using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end" )
            {
                string[] data = line.Split();

                Student student = new Student()
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Age = int.Parse(data[2]),
                    Town = data[3]
                };

                students.Add(student);
                line = Console.ReadLine();
            }

            string filterTown = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Town == filterTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }


    }
}
