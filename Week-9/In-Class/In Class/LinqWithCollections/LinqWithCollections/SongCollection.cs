using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class SongCollection : List<Song>
    {
        #region PlayedCount Examples
        //This is the traditional way to write a calculated property.
        public int PlayedCountCalculatedProperty
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

        //The "meat" of the above calculated property is the part that is determining whether the 
        //song has ever been played. We can put this into it's own method.
        public bool TimesPlayedMethod(Song song)
        {
            return song.TimesPlayed > 0;
        }

        //We can also put it in a Func Delegate - this is a way to have a method be passed as a parameter
        Func<Song, bool> timesPlayedFunc = song => song.TimesPlayed > 0;

        //We can then simplify our calculated property by passing our func into a 
        //Count method on the list. 
        //We are basically saying here - give me the count of items in this list where the func
        //timesPlayedFunc evaluates to true.
        public int PlayedCountUsingFunc
        {
            get
            {
                return this.Count(timesPlayedFunc);
            }
        }
        //We can put the above into an expression bodied property to save space
        public int PlayedCountUsingFuncExpressionBodied => this.Count(timesPlayedFunc);

        //And, finally, we can save ourselves from needing to define the Func altogether 
        //by simply passing the expression into Count() as a lambda expression
        public int PlayedCount => this.Count(x => x.TimesPlayed > 0);
        #endregion

        #region TotalPlayed Examples
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
        public int TotalPlayingTime => this.Sum(x => x.Length);
        #endregion

        #region GetAllArtist Examples
        public IEnumerable<Song> GetAllByArtistOW(string artist)
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
        public IEnumerable<Song> GetAllByArtistQuerySyntax(string artist)
        {
            var query = from song in this
                        where song.Artist.ToUpper() == artist.ToUpper()
                        orderby song.Title
                        select song;

            return query.ToList();
        }
        public IEnumerable<Song> GetAllByArtistMethodSyntaxExpressionBodied(string artist)
                         => this.OrderBy(x => x.Title)
                                .Where(x => x.Artist.ToUpper() == artist.ToUpper());
        
        //public IEnumerable<Song> GetAllByArtistMethodSyntaxExpressionBodied(string artist)
         //   {
        //   return this.OrderBy(x => x.Title).Where(x => x.Artist.ToUpper() == artist.ToUpper());
    }    //   }
    #endregion
}
