using System;
using System.Threading.Channels;

namespace Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string resultLetter = "";

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int toEncode = Convert.ToInt32(letter) + key;
                resultLetter += Convert.ToChar(toEncode);
            }
            Console.WriteLine(resultLetter);
        }
    }
}
