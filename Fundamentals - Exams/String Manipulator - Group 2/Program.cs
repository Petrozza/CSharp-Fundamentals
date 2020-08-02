using System;

namespace String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Done")
            {
                if (command[0] == "Change")
                {
                    char chr = char.Parse(command[1].ToString());
                    char replacement = char.Parse(command[2].ToString());
                    input = input.Replace(chr, replacement);
                    Console.WriteLine(input);
                }

                if (command[0] == "Includes")
                {
                    string str = command[1];
                    if (input.Contains(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                if (command[0] == "End")
                {
                    string str = command[1];
                    if (input.EndsWith(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                if (command[0] == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }

                if (command[0] == "FindIndex")
                {
                    char chr = char.Parse(command[1].ToString());
                    int index = input.IndexOf(chr);
                    Console.WriteLine(index);
                }

                if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int len = int.Parse(command[2]);
                    if (IsValid(startIndex, input))
                    {
                        string temp = input.Substring(startIndex, len);
                        input = new string(temp);
                        Console.WriteLine(input);
                    }
                }

                command = Console.ReadLine().Split();
            }
        }
        static bool IsValid(int index, string input)
        {
            if (index >= 0 && index < input.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
