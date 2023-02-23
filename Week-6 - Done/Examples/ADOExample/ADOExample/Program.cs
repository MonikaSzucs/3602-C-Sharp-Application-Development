using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ADO.NET Example";

            try
            {
                SongList songs = SongRepository.GetAllSongs();
                ConsolePrinter.PrintSongCollection(songs);
                Console.ReadLine();

                songs = SongRepository.GetAllSongsByArtist("eric clapton");
                ConsolePrinter.PrintSongCollection(songs);
                Console.ReadLine();

                songs = SongRepository.GetAllSongsByArtistV2();
                ConsolePrinter.PrintSongCollection(songs);
                Console.ReadLine();

                songs = SongRepository.GetAllSongsByArtistV2("black sabbath");
                ConsolePrinter.PrintSongCollection(songs);
            }

            catch (SqlException ex)
            {
                Console.WriteLine($"Data Access Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Processing Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }
    }
}
