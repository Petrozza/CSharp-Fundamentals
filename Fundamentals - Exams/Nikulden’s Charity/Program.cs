using System;
using System.Data;
using System.Linq;
using System.Text;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();

            string line = Console.ReadLine();
            while (line != "Finish")
            {
                string[] command = line.Split();

                if (command.Contains("Replace"))
                {
                    char currentChar = char.Parse(command[1]);
                    char newChar = char.Parse(command[2]);
                    result = result.Replace(currentChar, newChar);
                    Console.WriteLine(result);
                }

                if (command.Contains("Cut"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endtIndex = int.Parse(command[2]);
                    if (IsValid(startIndex, endtIndex, result))
                    {
                        result = result.Remove(startIndex, endtIndex - startIndex+1);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                if (command.Contains("Make"))
                {
                    if (command[1] == "Upper")
                    {
                        result = result.ToUpper();
                    }
                    else if (command[1] == "Lower")
                    {
                        result = result.ToLower();
                    }
                    Console.WriteLine(result);
                }

                if (command.Contains("Check"))
                {
                    string stringForCheck = command[1];
                    if (result.Contains(stringForCheck))
                    {
                        Console.WriteLine($"Message contains {stringForCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {stringForCheck}");
                    }
                }

                if (command.Contains("Sum"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endtIndex = int.Parse(command[2]);

                    if (IsValid(startIndex, endtIndex, result))
                    {
                        string sub = result.Substring(startIndex, endtIndex - startIndex +1);
                        int sum = 0;
                        for (int i = 0; i < sub.Length; i++)
                        {
                            sum += (int)sub[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                line = Console.ReadLine();
            }
        }
        static bool IsValid(int index1, int index2, string line)
        {
            if (index1 >= 0 && index2 >= 0 && index1 < line.Length && index2 < line.Length)
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
