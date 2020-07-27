using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumbers(n);
        }

        static void PrintTopNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;

                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 8 == 0)
                {
                    string forOddCheck = i.ToString();

                    for (int j = 0; j < forOddCheck.Length; j++)
                    {
                        if (forOddCheck[j] % 2 != 0)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }

                }
            }

        }
    }
}

