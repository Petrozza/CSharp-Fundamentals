using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            var forces = new Dictionary<string, List<string>>();

            while (data != "Lumpawaroo")
            {
                string[] input = data.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (data.Contains("|"))
                {
                    string side = input[0];
                    string user = input[1];
                    AddUserToSide(forces, side, user);
                }

                if (data.Contains("->"))
                {
                    string side = input[1];
                    string user = input[0];
                    ChangeUserSide(forces, side, user);

                    forces[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

                data = Console.ReadLine();

            }

            foreach (var force in forces
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(y => y.Key)
                    .Where(c => c.Value.Count > 0))
            {
                Console.WriteLine($"Side: {force.Key}, Members: {force.Value.Count}");

                foreach (var member in force.Value.OrderBy(c => c))
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }

        private static void ChangeUserSide(Dictionary<string, List<string>> forces, string side, string user)
        {
            foreach (var pair in forces)
            {
                if (pair.Value.Contains(user))
                {
                    pair.Value.Remove(user);
                }

            }
            if (!forces.ContainsKey(side))
            {
                forces[side] = new List<string>();
            }
        }

        private static void AddUserToSide(Dictionary<string, List<string>> forces, string side, string user)
        {
            if (!forces.ContainsKey(side))
            {
                forces[side] = new List<string>();
            }

            if (!forces.Values.Any(x => x.Contains(user)))
            {
                forces[side].Add(user);
            }
        }
    }
}


