using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUni.Exam.Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }

                string[] command = input.Split('-');

                string user = command[0];
                string language = command[1];

                if (command.Length == 2)
                {
                    participants.Remove(user);
                    continue;
                }

                int points = int.Parse(command[2]);

                if (!participants.ContainsKey(user))
                {
                    participants[user] = points;

                }
                else
                {
                    if (points > participants[user])
                    {
                        participants[user] = points;
                    }
                }

                if (!submissions.ContainsKey(language))
                {
                    submissions[language] = 1;
                }
                else
                {
                    submissions[language]++;
                }
            }

            Console.WriteLine($"Results:");
            Console.WriteLine(string.Join(Environment.NewLine, participants
                .OrderByDescending(x => x.Value)
                .ThenBy(y => y.Key)
                .Select(s => $"{s.Key} | {s.Value}")));
            Console.WriteLine($"Submissions:");
            Console.WriteLine(string.Join(Environment.NewLine, submissions
                .OrderByDescending(x => x.Value)
                .ThenBy(y => y.Key)
                .Select(s => $"{s.Key} - {s.Value}")));
        }
    }
}

