using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            CheckNumbers(num);
        }

        static void CheckNumbers(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("1");
            }
            else if (num == 2)
            {
                Console.WriteLine("1" + " 1");
            }
            else if (num == 3)
            {
                Console.WriteLine("1" + " 1" + " 2");
            }
            else
            {
                tribonacciSeq(num);
            }

        }

        static void tribonacciSeq(int num)
        {
            int[] arr = new int[num];

            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i < num; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }

            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
