using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Decode")
                {
                    break;
                }

                string[] command = input.Split('|');

                if (command[0] == "Move")
                {
                    int count = int.Parse(command[1]);
                    if (count > message.Length)
                    {
                        continue;
                    }
                    string moved = message.Substring(0, count);
                    message = message.Remove(0, count);
                    message = message + moved;
                }

                if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string isertion = command[2];
                    if (index >= 0 && index <= message.Length) //idex > 0 or 1
                    {
                        message = message.Insert(index, isertion).ToString();
                    }
                }

                if (command[0] == "ChangeAll")
                {
                    string sub = command[1];
                    string repl = command[2];
                    message = message.Replace(sub, repl);
                }
             }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
