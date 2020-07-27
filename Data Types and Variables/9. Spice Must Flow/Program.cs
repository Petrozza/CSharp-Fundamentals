using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalStore = 0;
            int count = 0;

            while (yield >= 100)
            {
                int store = yield;
                if (store > 26)
                {
                    store -= 26;
                }
                else
                {
                    store = 0;
                }
                totalStore += store;
                yield -= 10;
                count++;
            }
            
            if (totalStore > 26)
            {
                totalStore -= 26;
            }
            else
            {
                totalStore = 0;
            }
            
            Console.WriteLine(count);
            Console.WriteLine(totalStore);
        }
    }
}
