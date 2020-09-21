using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var playlist = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                if (!playlist.ContainsKey(piece))
                {
                    playlist.Add(piece, new List<string>() { composer, key });
                }
                else
                {
                    playlist[piece].Add(composer);
                    playlist[piece].Add(key);
                }
            }

            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2 == "Stop")
                {
                    break;
                }

                string[] command = input2.Split('|');

                if (command[0] == "Add")
                {
                    string piece = command[1];
                    string composer = command[2];
                    string key = command[3];

                    if (playlist.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        playlist.Add(piece, new List<string>());
                        playlist[piece].Add(composer);
                        playlist[piece].Add(key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }

                if (command[0] == "Remove")
                {
                    string piece = command[1];
                    if (playlist.ContainsKey(piece))
                    {
                        playlist.Remove(piece);
                        Console.WriteLine($"Successfully removed { piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                if (command[0] == "ChangeKey")
                {
                    string piece = command[1];
                    string newKey = command[2];
                    if (playlist.ContainsKey(piece))
                    {
                        playlist[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

            }
            foreach (var piece in playlist.OrderBy(x => x.Key).ThenBy(y => y.Value))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
