using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morse.Code.Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var morse = new Dictionary<string, char>();
            morse.Add(".-", 'A');
            morse.Add("-...", 'B');
            morse.Add("-.-.", 'C');
            morse.Add("-..", 'D');
            morse.Add(".", 'E');
            morse.Add("..-.", 'F');
            morse.Add("--.", 'G');
            morse.Add("....", 'H');
            morse.Add("..", 'I');
            morse.Add(".---", 'J');
            morse.Add("-.-", 'K');
            morse.Add(".-..", 'L');
            morse.Add("--", 'M');
            morse.Add("-.", 'N');
            morse.Add("---", 'O');
            morse.Add(".--.", 'P');
            morse.Add("--.-", 'Q');
            morse.Add(".-.", 'R');
            morse.Add("...", 'S');
            morse.Add("-", 'T');
            morse.Add("..-", 'U');
            morse.Add("...-", 'V');
            morse.Add(".--", 'W');
            morse.Add("-..-", 'X');
            morse.Add("-.--", 'Y');
            morse.Add("--..", 'Z');
            morse.Add("|", '|');

            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string msg = "";

            for (int i = 0; i < words.Length; i++)
            {

                string symbol = words[i];
                if (morse.ContainsKey(symbol))
                {
                    char newSymbol = morse[symbol];
                    msg += newSymbol;
                }
                else
                {
                    break;
                }

            }

            StringBuilder sb = new StringBuilder(msg);
            sb.Replace('|', ' ').ToString();

            Console.WriteLine(sb);

        }
    }
}

