using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Song> tracks = new List<Song>();

            for (int i = 1; i <= N; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                tracks.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in tracks)
                {
                    Console.WriteLine(song.Name);
                }
              
            }
            else
            {
                foreach (Song song in tracks)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            //List<Song> filteredSongs = tracks.Where(s => s.TypeList == typeList).ToList();

            //foreach (Song song in  filteredSongs)
            //{
            //    Console.WriteLine(song.Name);
            //}
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
