using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split().ToArray();

            List<People> guys = new List<People>();

            while (line[0] != "End")
            {
                string name = line[0];
                string id = line[1];
                int age = int.Parse(line[2]);
                People guy = new People(name, id, age);
                guys.Add(guy);

                line = Console.ReadLine()
                .Split().ToArray();
            }
            guys = guys.OrderBy(l => l.Age).ToList();

            foreach (var guy in guys)
            {
                Console.WriteLine($"{guy.Name} with ID: {guy.ID} is {guy.Age} years old.");
            }

        }

        public class People
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public People(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }
        }
    }
}

