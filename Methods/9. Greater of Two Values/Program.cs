using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            switch (type)
            {
                case "int":
                    int v1 = int.Parse(Console.ReadLine());
                    int v2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxValue(v1, v2));
                    break;
                case "char":
                    char b1 = char.Parse(Console.ReadLine());
                    char b2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxValue(b1, b2));
                    break;
                case "string":
                    string s1 = Console.ReadLine();
                    string s2 = Console.ReadLine();
                    Console.WriteLine(GetMaxValue(s1, s2));
                    break;
            }
        }

        static int GetMaxValue(int v1, int v2)
        {
            int compare = v1.CompareTo(v2);
            int result = 0;
            if (compare > 0)
            {
                result = v1;
            }
            else if (compare < 0)
            {
                result = v2;
            }
            return result;
        }

        static char GetMaxValue(char b1, char b2)
        {
            int compare = b1.CompareTo(b2);
            char result = ' ';
            if (compare > 0)
            {
                result = b1;
            }
            else if (compare < 0)
            {
                result = b2;
            }
            return result;
        }

        static string GetMaxValue(string s1, string s2)
        {
            int compare = s1.CompareTo(s2);
            string result = "";
            if (compare > 0)
            {
                result = s1;
            }
            else if (compare < 0)
            {
                result = s2;
            }
            return result;
        }


    }
}
