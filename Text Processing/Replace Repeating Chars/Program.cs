using System;
using System.Linq;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";

            for (int i = text.Length - 1; i > 0; i--)
            {

                if (text[i] != text[i - 1])
                {
                    result += text[i];
                    continue;
                }
                else
                {
                    continue;
                }
                
            }
            result += text[0];
            char[] charArr = result.ToCharArray();
            Array.Reverse(charArr);
            Console.WriteLine(charArr);
        }
    }
}
