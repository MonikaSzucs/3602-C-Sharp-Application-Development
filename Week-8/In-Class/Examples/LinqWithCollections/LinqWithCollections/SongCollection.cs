using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class SongCollection : List<Song>
    {
        public int PlayedCount => this.Count(x => x.TimesPlayed > 0);

        public int TotalPlayingTime => this.Sum(x => x.Length);

        public IEnumerable<Song> GetAllByArtist(string artist)
                                 => this.OrderBy(x => x.Title)
                                        .Where(x => x.Artist.ToUpper() == artist.ToUpper());


        public int PlayedCountOW
        {
            get
            {
                int count = 0;

                foreach (Song song in this)
                {
                    if (song.TimesPlayed > 0)
                    {
                        count += 1;
                    }
                }

                return count;
            }
        }

        public int TotalPlayingTimeOW
        {
            get
            {
                int count = 0;

                foreach (Song song in this)
                {
                    count += song.Length;
                }

                return count;
            }
        }

        public IEnumerable<Song> GetAllByArtistOW1(string artist)
        {
            var songsByArtist = new List<Song>();

            foreach (Song song in this)
            {
                if (song.Artist.ToUpper() == artist.ToUpper())
                {
                    songsByArtist.Add(song);
                }
            }

            return songsByArtist;
        }

        public IEnumerable<Song> GetAllByArtistOW2(string artist)
        {
            var query = from song in this
                        where song.Artist.ToUpper() == artist.ToUpper()
                        orderby song.Title
                        select song;

            return query.ToList();
        }
    }
}
