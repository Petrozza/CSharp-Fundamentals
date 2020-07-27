using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrFirst = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> result = new List<string>();
            for (int i = arrFirst.Length - 1; i >= 0; i--)
            {
                string[] arrSecond = arrFirst[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string item in arrSecond)
                {
                    result.Add(item);
                }
                
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
