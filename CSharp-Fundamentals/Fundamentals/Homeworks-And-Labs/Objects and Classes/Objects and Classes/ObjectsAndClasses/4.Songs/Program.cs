using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Songs
{
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                List<string> input = Console.ReadLine().Split("_").ToList();

                Song song = new Song();
                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if(command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (command == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
