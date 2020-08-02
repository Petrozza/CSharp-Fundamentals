using System;
using System.Linq;
using System.Text;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Generate")
                {
                    break;
                }
                string[] command = input.Split(">>>");

                if (command.Contains("Contains"))
                {
                    string substring = command[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (command.Contains("Flip"))
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string result = "";

                    for (int i = 0; i < activationKey.Length; i++)
                    {
                        if (i >= startIndex && i < endIndex && command[1] == "Upper")
                        {
                            result += activationKey[i].ToString().ToUpper();

                        }
                        else if (i >= startIndex && i < endIndex && command[1] == "Lower")
                        {
                            result += activationKey[i].ToString().ToLower();
                        }
                        else
                        {
                            result += activationKey[i].ToString();
                        }
                    }
                    activationKey = result;
                    Console.WriteLine(activationKey);
                }

                if (command.Contains("Slice"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int length = endIndex - startIndex;
                    activationKey =  activationKey.Remove(startIndex, length);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
