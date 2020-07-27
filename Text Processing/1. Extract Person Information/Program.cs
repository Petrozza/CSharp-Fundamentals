using System;

namespace _1._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                int nameStart = line.IndexOf('@') + 1;
                int nameLength = line.IndexOf('|') - nameStart;
                int ageStart = line.IndexOf('#') + 1;
                int ageLength = line.IndexOf('*') - ageStart;

                string name = line.Substring(nameStart, nameLength);
                string age = line.Substring(ageStart, ageLength);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
