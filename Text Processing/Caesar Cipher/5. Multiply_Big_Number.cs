using System;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine().TrimStart('0');
            int smallNum = int.Parse(Console.ReadLine());

            if (smallNum == 0)
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(bigNum[i].ToString()) * smallNum + remainder;
                remainder = 0;
                if (result > 9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }

                sb.Append(result);
            }
            if (remainder > 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reverse = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reverse.Append(sb[i]);
            }

            Console.WriteLine(reverse);


        }
    }
}

        
