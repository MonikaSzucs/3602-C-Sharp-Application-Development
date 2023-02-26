using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class ConsolePrinter
    {
        public static void DisplaySongs(IEnumerable<Song> songs)
        {
            Console.WriteLine($"{"Artist",-30} {"Title",-30} {"Length",6}\n{new string('-', 68)}");
                          
            foreach (Song song in songs)
            {
                Console.WriteLine($"{song.Artist, -30} {song.Title, -30} {song.Length, 6}");
            }

            Console.WriteLine();
        }
    }
}
