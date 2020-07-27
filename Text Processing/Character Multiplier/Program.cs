using System;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int result = MultipliedStrings(input[0], input[1]);
            Console.WriteLine(result);
        }

        static int MultipliedStrings(string str1, string str2)
        {
            int result = 0;
            int a = str1.Length;
            int b = str2.Length;

            for (int i = 0; i < Math.Min(a, b); i++)
            {
                result += str1[i] * str2[i];
            }

            if (a > b)
            {
                for (int i = b; i < a; i++)
                {
                    result += str1[i];
                }
            }

            else if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    result += str2[i];
                }
            }

            return result;

        }
    }
}