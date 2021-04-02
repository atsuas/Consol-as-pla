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
