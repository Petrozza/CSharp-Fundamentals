using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < n+97; i++)
            {
                for (int j = 97; j < n+97; j++)
                {
                    for (int k = 97; k < n+97; k++)
                    {
                        char ii = Convert.ToChar(i);
                        char jj = Convert.ToChar(j);
                        char kk = Convert.ToChar(k);
                        Console.WriteLine($"{ii}{jj}{kk}");
                    }
                }
            }
        }
    }
}
