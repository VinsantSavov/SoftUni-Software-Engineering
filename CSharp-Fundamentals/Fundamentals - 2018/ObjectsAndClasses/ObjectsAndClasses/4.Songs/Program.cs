using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                List<string> line = Console.ReadLine().Split("_").ToList();

                Song song = new Song();
                song.TypeList = line[0];
                song.Name = line[1];
                song.Time = line[2];

                songs.Add(song);

            }

            string typeList = Console.ReadLine();

            if(typeList == "all")
            {
                foreach (var kvp in songs)
                {
                    Console.WriteLine(kvp.Name);
                }
            }
            else
            {
                foreach (var kvp in songs)
                {
                    if (kvp.TypeList == typeList)
                    {
                        Console.WriteLine(kvp.Name);
                    }
                }
            }
        }
    }
}
