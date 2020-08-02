using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Sign up")
                {
                    break;
                }
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Case":
                        if (command[1] == "upper")
                        {
                            name = name.ToUpper();
                        }
                        else if (command[1] == "lower")
                        {
                            name = name.ToLower();
                        }
                        Console.WriteLine(name);
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (IsValid(startIndex, name) && IsValid(endIndex, name))
                        {
                            string sub = name.Substring(startIndex, endIndex - startIndex + 1);
                            string reverse = "";
                            for (int i = sub.Length - 1; i >= 0; i--)
                            {
                                reverse += sub[i];
                            }
                            Console.WriteLine(reverse);
                        }
                        break;

                    case "Cut":
                        string substring = command[1];
                        if (name.Contains(substring))
                        {
                            int index = name.IndexOf(substring);
                            name = name.Remove(index, substring.Length);
                            Console.WriteLine(name);
                        }
                        else
                        {
                            Console.WriteLine($"The word {name} doesn't contain {substring}.");
                        }
                        break;

                    case "Check":
                        char chr = char.Parse(command[1].ToString());
                        if (name.Contains(chr))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {chr}.");
                        }
                        break;

                    case "Replace":
                        chr = char.Parse(command[1].ToString());
                        if (name.Contains(chr))
                        {
                            name = name.Replace(chr, '*');
                            Console.WriteLine(name);
                        }
                        break;
                }
            }
        }

        static bool IsValid(int index, string str)
        {
            if (index >= 0 && index < str.Length)
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
