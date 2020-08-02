using System;
using System.Linq;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Complete")
                {
                    break;
                }
                string[] command = input.Split();

                 if (command.Contains("Upper"))
                {
                    email = email.ToUpper();
                    Console.WriteLine(email);
                }
                else if (command.Contains("Lower"))
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }

                else if (command[0] == "GetDomain")
                {
                    int lastCount = int.Parse(command[1]);
                    string domain = email.Substring(email.Length - lastCount);
                    Console.WriteLine(domain);
                }
                else if (command[0] == "GetUsername")
                {
                    if (email.Contains('@'))
                    {
                        int index = email.IndexOf('@');
                        string sub = email.Substring(0, index);
                        Console.WriteLine(sub);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (command[0] == "Replace")
                {
                    char chr = char.Parse(command[1]);
                    email = email.Replace(chr, '-');
                    Console.WriteLine(email);
                }
                else if (command[0] == "Encrypt")
                {
                    
                    for (int i = 0; i < email.Length; i++)
                    {
                        int ascii = email[i];
                        Console.Write($"{ascii} ");
                    }
                     Console.WriteLine();
                }
            }  
        }
    }
}
