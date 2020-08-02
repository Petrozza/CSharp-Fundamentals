
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "For Azeroth")
                {
                    break;
                }
                string[] command = input.Split();

                if (command[0] == "GladiatorStance")
                {
                    line = line.ToUpper();
                    Console.WriteLine(line);
                }

                else if (command[0] == "DefensiveStance")
                {
                    line = line.ToLower();
                    Console.WriteLine(line);
                }

                else if (command[0] == "Dispel")
                {
                    int index = int.Parse(command[1]);
                    char letter = char.Parse(command[2]);
                    if (!(index >= 0 && index < line.Length))
                    {
                        Console.WriteLine("Dispel too weak.");
                        continue;
                    }
                    else
                    {
                        char[] temp = line.ToCharArray();
                        temp[index] = letter;
                        line = new string(temp);
                        Console.WriteLine("Success!");
                    }
                }

                else if (command[1] == "Change")
                {
                    string substring = command[2];
                    string substring2 = command[3];

                    line = line.Replace(substring, substring2);
                    Console.WriteLine(line);
                }

                else if (command[1] == "Remove")
                {
                    if (command[2].Length > line.Length)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        line = line.Replace(command[2], string.Empty);
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
