using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int endFibonacci = int.Parse(Console.ReadLine());
            if (endFibonacci == 1)
            {
                Console.WriteLine(1);
                return;
            }
            int[] arr = new int[endFibonacci];
            int fNumber = 0;


            arr[0] = 1;
            arr[1] = 1;


            for (int i = 2; i < endFibonacci; i++)
            {

                arr[i] = arr[i - 1] + arr[i - 2];
                fNumber = arr[i];
            }
            Console.WriteLine(fNumber);
        }
    }
}
