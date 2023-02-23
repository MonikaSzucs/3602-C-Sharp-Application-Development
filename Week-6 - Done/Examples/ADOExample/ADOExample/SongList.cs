using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample
{
    class SongList : List<Song>
    {
        public int TotalLength
        {
            get
            {
                int total = 0;

                foreach (Song song in this)
                {
                    total += song.Length;
                }

                return total;
            }
        }
    }
}
