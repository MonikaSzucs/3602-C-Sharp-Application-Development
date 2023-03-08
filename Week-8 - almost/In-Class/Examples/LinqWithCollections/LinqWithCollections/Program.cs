using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LINQ With Collections";

            SongCollection mySongs = DataGenerator.CreateSongs();

            Console.WriteLine("Natural Order:");
            ConsolePrinter.DisplaySongs(mySongs);
            Console.ReadLine();


            var query = from song in mySongs
                        orderby song.Artist, song.Title
                        select song;

            var queryM = mySongs.OrderBy(x => x.Artist)
                                .ThenBy(x => x.Title);

            Console.WriteLine("Sorted by Artist, Title");
            ConsolePrinter.DisplaySongs(queryM.ToList());

            Console.ReadLine();

            string artist = "Eric Clapton";

            var queryFilterQS = from song in mySongs
                                where song.Artist.ToUpper() == artist.ToUpper()
                                orderby song.Title
                                select song;

            var queryFilterMS = mySongs.OrderBy(x => x.Title)
                                       .Where(x => x.Artist.ToUpper() == artist.ToUpper());

            Console.WriteLine("Filtered by Artist: {0}", artist);
            ConsolePrinter.DisplaySongs(queryFilterQS.ToList());
            ConsolePrinter.DisplaySongs(queryFilterMS.ToList());
            ConsolePrinter.DisplaySongs(mySongs.GetAllByArtist(artist));
            ConsolePrinter.DisplaySongs(mySongs.GetAllByArtistOW1(artist));
            ConsolePrinter.DisplaySongs(mySongs.GetAllByArtistOW2(artist));

            Console.ReadLine();

            Console.WriteLine("Total Length and Average using Lambda Expressions");

            int totalLength = mySongs.TotalPlayingTime;
            Console.WriteLine("{0, -7}: {1:N0}", "Total", totalLength);

            totalLength = mySongs.TotalPlayingTimeOW;
            Console.WriteLine("{0, -7}: {1:N0}", "Total", totalLength);

            TimeSpan span = new TimeSpan(0, 0, totalLength);
            Console.WriteLine("{0, -7}: {1:D2}:{2:D2}:{3:D2}"
                                , "Total"
                                , span.Hours
                                , span.Minutes
                                , span.Seconds);

            int average = (int)mySongs.Average(x => x.Length);
            Console.WriteLine("{0, -7}: {1:N0}", "Average", average);

            TimeSpan spanAverage = new TimeSpan(0, 0, average);
            Console.WriteLine("{0, -7}: {1:D2}:{2:D2}:{3:D2}"
                                , "Average"
                                , spanAverage.Hours
                                , spanAverage.Minutes
                                , spanAverage.Seconds);

            Console.ReadLine();

            mySongs[23].Play();
            mySongs[12].Play();
            mySongs[8].Play();
            mySongs[12].Play();

            Console.WriteLine("Played Count: {0}", mySongs.PlayedCount);
            Console.WriteLine("Played Count: {0}", mySongs.PlayedCountOW);

            Console.ReadLine();


            var querySingleField = from song in mySongs
                                   orderby song.Artist
                                   select song.Artist;

            Console.WriteLine("Sorted Artist List (includes duplicates)");
            foreach (string artistName in querySingleField.ToList())
            {
                Console.WriteLine(artistName);
            }

            Console.ReadLine();

            var querySingleFieldDistinct = (from song in mySongs
                                            orderby song.Artist
                                            select song.Artist).Distinct();

            Console.WriteLine("Sorted Artist List (no duplicates)");
            foreach (string artistName in querySingleFieldDistinct.ToList())
            {
                Console.WriteLine(artistName);
            }
        }
    }
}
