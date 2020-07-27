using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Take.Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var nonNumbers = new List<char>();
            var numbers = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                
                if(Char.IsDigit(str[i]))
                {
                    int number = int.Parse(str[i].ToString());
                    numbers.Add(number);
                    str = str.Remove(i, 1);
                    i--;
                }
                else
                {
                    nonNumbers.Add(str[i]);
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
            string result = null;
            var total = 0;
            for (int index = 0; index < skipList.Count; index++)
            {
                int skipCount = skipList[index];
                int takeCoun = takeList[index];
                result += new string(nonNumbers.Skip(total).Take(takeCoun).ToArray());
                total += skipCount + takeCoun;
            }
            Console.WriteLine(result);

        }
    }
}
