using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMultipleString(Console.ReadLine(),
                int.Parse(Console.ReadLine())));
        }

        static string GetMultipleString(string str, int counter)
        {
            string result = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
