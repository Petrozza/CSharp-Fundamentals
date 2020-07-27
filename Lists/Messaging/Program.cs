using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string words = Console.ReadLine();
            string message = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int num = numbers[i];
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                int index = sum;
                if (index > words.Length - 1)
                {
                    index -= words.Length;
                    message += words[index];
                }
                else
                {
                    message += words[index];
                }
                words = words.Remove(index, 1);
                
            }
            Console.WriteLine(message);
        }
    }
}
