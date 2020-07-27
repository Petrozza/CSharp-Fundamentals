using System;
using System.Linq;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (true)
            {
                string[] command = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Reveal")
                {
                    break;
                }

                if (command[0] == "InsertSpace")
                {
                    text = text.Insert(int.Parse(command[1]), " ").ToString();
                    Console.WriteLine(text);
                }

                if (command[0] == "Reverse")
                {
                    string message = command[1];
                    if (text.Contains(message))
                    {
                        int startIndex = text.IndexOf(message);
                        string removed = text.Substring(startIndex, message.Length).ToString();
                        string reversed = "";
                        for (int i = removed.Length - 1; i >= 0; i--)
                        {
                            reversed += removed[i];
                        }
                        text = text.Insert(text.Length, reversed);
                        text = text.Remove(startIndex, message.Length);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                if (command[0] == "ChangeAll")
                {
                    string string1 = command[1];
                    string repla = command[2];

                    text = text.Replace(string1, repla).ToString();
                    Console.WriteLine(text);
                }

            }
            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
