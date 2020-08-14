using System;
using System.Dynamic;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Translate")
                {
                    char chr = char.Parse(command[1].ToString());
                    char repla = char.Parse(command[2].ToString());
                    result = result.Replace(chr, repla);
                    Console.WriteLine(result);
                }

                else if (command[0] == "Includes")
                {
                    string str = command[1];
                    if (result.Contains(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (command[0] == "Start")
                {
                    if (result.StartsWith(command[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (command[0] == "Lowercase")
                {
                    result = result.ToLower();
                    Console.WriteLine(result);
                }

                else if (command[0] == "FindIndex")
                {
                    char chr = char.Parse(command[1].ToString());
                    Console.WriteLine(result.LastIndexOf(chr));
                }

                else if (command[0] == "Remove")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    string temp = result.Remove(startIndex, count);
                    result = new string(temp);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
