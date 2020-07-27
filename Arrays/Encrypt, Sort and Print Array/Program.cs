using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int[] resu = new int[n];


            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                //int sumConso = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'a' || name[j] == 'o' || name[j] == 'e'
                        || name[j] == 'u' || name[j] == 'i' ||
                        name[j] == 'A' || name[j] == 'O' || name[j] == 'E'
                        || name[j] == 'U' || name[j] == 'I')
                    {
                        sum += name[j] * name.Length;
                    }
                    else
                    {
                        sum += name[j] / name.Length;
                    }
                    //sult = sumvowel + sumConso;
                }
                //Console.WriteLine(result);
                resu[i] = sum;
            }
            Array.Sort(resu);
            foreach (var item in resu)
            {
                Console.WriteLine(item);
            }

        }
    }
}

