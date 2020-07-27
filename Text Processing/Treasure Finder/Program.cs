using System;
using System.Text;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split();
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

                int j = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (j > key.Length - 1)
                {
                    j = 0;
                }
                char newChar = (char)(Convert.ToInt32(line[i]) - Convert.ToInt32(key[j]));
                j++;
                sb.Append(newChar);

                

            }
            Console.WriteLine(sb);
        }
    }
}
