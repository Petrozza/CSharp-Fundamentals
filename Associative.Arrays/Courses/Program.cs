using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ").ToArray();
            var courses = new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                string courseName = input[0];
                string student = input[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(student);
                }
                else
                {
                    courses[courseName].Add(student);
                }
                input = Console.ReadLine().Split(" : ").ToArray();
            }

            foreach (var pair in courses.OrderByDescending(p => p.Value.Count))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

                foreach (var kid in pair.Value.OrderBy(k => k))
                {
                    Console.WriteLine($"-- {kid}");
                }
            }
        }
    }
}

