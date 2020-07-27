using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] data = line.Split();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string town = data[3];

                if (IfStudentExists(students, firstName, lastName))
                {
                    GetStudent(students, firstName, lastName, age);
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Town = town
                    };
                    students.Add(student);
                }


                line = Console.ReadLine();
            }

            

            string filteredTown = Console.ReadLine();
            
            foreach (Student student in students)
            {
               if (student.Town == filteredTown)
               {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
               }
            }

        }

        static void GetStudent(List<Student> students, string firstName, string lastName, int age)
        {

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Town = student.Town;
                }
            }
        }

        static bool IfStudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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
