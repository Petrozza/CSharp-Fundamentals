using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[7] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };

            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num <=7)
            {
                Console.WriteLine(day[num-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

            
        }
    }
}
