using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string reg = Console.ReadLine();
                string namePattern = @"(U\$)(?<name>[A-Z][a-z]{2,})(\1)";
                string passPattern = @"(P@\$)(?<pass>[a-zA-Z]{5,}[\d]+)(\1)";

                Match user = Regex.Match(reg, namePattern);
                Match pass = Regex.Match(reg, passPattern);

                if (user.Success && pass.Success)
                {
                    string userName = user.Groups["name"].Value;
                    string passWord = pass.Groups["pass"].Value;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {userName}, Password: {passWord}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}

