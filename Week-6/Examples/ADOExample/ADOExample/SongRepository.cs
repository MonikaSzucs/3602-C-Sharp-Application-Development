using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample
{
    class SongRepository
    {

        private static readonly string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                                      Initial Catalog=comp2614;
                                                      User ID=student;
                                                      Password=p8SmM5/mKZk=;
                                                      Encrypt=True;
                                                      TrustServerCertificate=False;
                                                      Connection Timeout=30;";
        public static SongList GetAllSongs()
        {
            SongList songs;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT Artist, Title, Length
                                 FROM Song
                                 ORDER BY Artist, Title";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    songs = new SongList();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string artist = null;
                        string title;
                        int length = 0;

                        while (reader.Read())
                        {
                            //No need to null check strings, can use "as" keyword
                            artist = reader[0] as string;

                            //NOT NULL column in SQL anyhow, can't be null
                            title = reader["Title"] as string;

                            //May be null in DB, need to null check before casting
                            if (!reader.IsDBNull(2))
                            {
                                length = (int)reader["Length"];
                            }

                            songs.Add(new Song(artist, title, length));

                            artist = null;
                            length = 0;
                        }
                    }
                    return songs;
                }
            }
        }

        public static SongList GetAllSongsByArtist(string artistFilter)
        {
            SongList songs;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT Artist, Title, Length
                                 FROM Song
                                 WHERE Artist = @artist
                                 ORDER BY Title";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@artist", artistFilter);

                    conn.Open();

                    songs = new SongList();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string artist = null;
                        string title;
                        int length = 0;

                        while (reader.Read())
                        {
                            artist = reader[0] as string;
                            title = reader["Title"] as string;

                            if (!reader.IsDBNull(2))
                            {
                                length = (int)reader["Length"];
                            }

                            songs.Add(new Song(artist, title, length));

                            artist = null;
                            length = 0;
                        }
                    }

                    return songs;
                }
            }
        }

        public static SongList GetAllSongsByArtistV2(string artistFilter = "**")
        {
            SongList songs;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query;

                if (artistFilter == "**")
                {
                    query = @"SELECT Artist, Title, Length
                              FROM Song
                              ORDER BY Artist, Title";
                }
                else
                {
                    query = @"SELECT Artist, Title, Length
                              FROM Song
                              WHERE Artist = @artist
                              ORDER BY Artist, Title";
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    if (artistFilter != "**")
                    {
                        cmd.Parameters.AddWithValue("@artist", artistFilter);
                    }

                    conn.Open();

                    songs = new SongList();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string artist = null;
                        string title;
                        int length = 0;

                        while (reader.Read())
                        {
                            artist = reader[0] as string;
                            title = reader["Title"] as string;

                            if (!reader.IsDBNull(2))
                            {
                                length = (int)reader["Length"];
                            }

                            songs.Add(new Song(artist, title, length));

                            artist = null;
                            length = 0;
                        }
                    }

                    return songs;
                }
            }
        }
    }
}
