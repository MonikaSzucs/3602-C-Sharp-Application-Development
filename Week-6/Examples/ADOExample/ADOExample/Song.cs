using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample
{
    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public int Length { get; }

        public Song(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist} Length: {Length}";
        }
    }
}
