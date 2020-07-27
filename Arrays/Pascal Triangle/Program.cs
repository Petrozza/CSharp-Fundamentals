using System;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            if (rows == 1)
            {
                return;
            }

            int[] originalArr = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", originalArr));
            if (rows == 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < originalArr.Length + 1; i++)
                {
                    int[] Arr = new int[originalArr.Length + 1];
                    Arr[0] = 1;
                    Arr[Arr.Length - 1] = 1;
                    for (int j = 1; j < Arr.Length - 1; j++)
                    {
                        Arr[j] = originalArr[j] + originalArr[j - 1];
                    }
                    Console.WriteLine(string.Join(" ", Arr));
                    originalArr = Arr;

                    if (originalArr.Length == rows)
                    {
                        return;
                    }
                }

            }


        }
    }
}

