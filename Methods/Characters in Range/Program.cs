using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            PrintSymbolsBetweenCharacters(one, two);
        }

        static void PrintSymbolsBetweenCharacters(char a, char b)
        {
            if (b < a)
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            else
            {
                for (int i = a + 1; i <= b - 1; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            

        }
    }
}
