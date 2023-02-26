using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public int Length { get; }
        public int TimesPlayed { get; private set; }

        public Song(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }

        public void Play() => TimesPlayed += 1;
        public override string ToString() => $"{Title} by {Artist}";
    }
}
