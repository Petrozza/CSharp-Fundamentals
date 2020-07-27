using System;
using System.Diagnostics.CodeAnalysis;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                string input = data[i];
                double number = int.Parse(input.Substring(1, input.Length - 2));

                input = input.Remove(1, input.Length - 2);
                char firsLetter = input[0];
                char lastLetter = input[1];

                if (firsLetter >= 65 && firsLetter <= 90)
                {
                    int firstUpperPosition = (int)char.Parse(firsLetter.ToString().ToUpper()) - 64;
                    number /= firstUpperPosition; //12
                }
                else
                {
                    int firstLowerPosition = (int)char.Parse(firsLetter.ToString().ToUpper()) - 64;
                    number *= firstLowerPosition;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int lastUpperPosition = (int)char.Parse(lastLetter.ToString().ToUpper()) - 64; //2
                    number -= lastUpperPosition;
                }
                else
                {
                    int lastLowerPosition = (int)char.Parse(lastLetter.ToString().ToUpper()) - 64; //2
                    number += lastLowerPosition;
                }
                 
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
            
         }
    }
}
