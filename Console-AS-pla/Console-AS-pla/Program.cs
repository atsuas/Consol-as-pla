using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AS
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[]
            {
               new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
            };

        }

        private static void PrintSongs(Song[] songs )
        {
            foreach (var song in songs)
            {
                Console.WriteLine(@"{0} {1} {2}", )
            }
        }

    }

    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public Song(string title, string artistname, int length)
        {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
