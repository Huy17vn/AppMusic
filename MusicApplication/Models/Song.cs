using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Models
{
    public class Song
    {
        public int SongID { get; set; }

        public string NameSong { get; set; }

        public string Singer { get; set; }

        public string Content { get; set; }

        public List<SongCategory> SongCategories { get; set; }
    }
}
