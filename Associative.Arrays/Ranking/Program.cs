using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(":").ToArray();
           
            var line1 = new Dictionary<string, string>(); 

            while (input1[0] != "end of contests")
            {
                string contest1 = input1[0];
                string pass1 = input1[1];

                if (!line1.ContainsKey(contest1))
                {
                    line1.Add(contest1, pass1);
                }

                input1 = Console.ReadLine().Split(":").ToArray();
            }

            
            string[] input2 = Console.ReadLine().Split("=>").ToArray();

            var line2 = new SortedDictionary<string, Dictionary<string, int>>(); 

            while (input2[0] != "end of submissions")
            {
                string contest2 = input2[0];
                string pass2 = input2[1];
                string userName = input2[2];
                int points = int.Parse(input2[3]);

                if (line1.ContainsKey(contest2) && line1.ContainsValue(pass2)) 
                {
                    if (!line2.ContainsKey(userName))
                    {
                        line2.Add(userName, new Dictionary<string, int>());
                        line2[userName].Add(contest2, points);
                    }

                    if (line2[userName].ContainsKey(contest2))
                    {
                        if (line2[userName][contest2] < points) 
                        {
                            line2[userName][contest2] = points;
                        }
                    }
                    else
                    {
                        line2[userName].Add(contest2, points);
                    }
                }
                input2 = Console.ReadLine().Split("=>").ToArray();
            }

            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            foreach (var kvp in line2)
            {
                totalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            string bestName = totalPoints.Keys.Max();
            int bestPoints = totalPoints.Values.Max();

            foreach (var kvp in totalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }
            Console.WriteLine("Ranking: ");
            
            foreach (var user in line2)
            {
                Dictionary<string, int> dict = user.Value.OrderByDescending(u => u.Value).ToDictionary(x => x.Key, y => y.Value);
                Console.WriteLine(user.Key);

                foreach (var cont in dict)
                {
                    Console.WriteLine($"#  {cont.Key} -> {cont.Value}");
                }
            }
        }
    }
}
