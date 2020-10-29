using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;

namespace _1._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                string[] command = input.Split(':');
                string cont = command[0];
                string pass = command[1];
                if (!inputData.ContainsKey(cont))
                {
                    inputData.Add(cont, pass);
                }
                else
                {
                    inputData[cont] = pass;
                }
            }
            var ranking = new Dictionary<string, Dictionary<string, int>>();
            //int maxPoints = 0;
            //string maxUser = "";
            //int sumpoints = 0;

            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2 == "end of submissions")
                {
                    break;
                }
                string[] data = input2.Split("=>").ToArray();
                string contest = data[0];
                string password = data[1];
                string username = data[2];
                int points = int.Parse(data[3]);


                if (inputData.ContainsKey(contest) && password == inputData[contest])
                {
                    if (!ranking.ContainsKey(username))
                    {
                        ranking.Add(username, new Dictionary<string, int>());
                        ranking[username].Add(contest, points);
                    }
                    if (!ranking[username].ContainsKey(contest))
                    {
                        ranking[username].Add(contest, points);
                    }

                    if (ranking[username][contest] < points)
                    {
                        ranking[username][contest] = points;
                    }
                }
            }

            var totalPoints = new Dictionary<string, int>();
            foreach (var item in ranking)
            {
                totalPoints[item.Key] = item.Value.Values.Sum();
            }
            int maxPoints = totalPoints.Values.Max();

            foreach (var pair in totalPoints)
            {
                if (pair.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {pair.Key} with total {pair.Value} points.");
                }
            }
           
            Console.WriteLine("Ranking: ");
            foreach (var item in ranking.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                var contests = item.Value;
                foreach (var pair in contests.OrderByDescending(y => y.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
