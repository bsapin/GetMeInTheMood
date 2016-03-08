using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMeInTheMood.Models
{
    public class Song
    {
        public int ID { get; set; }

        public string url { get; set; }

        public string status { get; set; }

        public List<Playlist> playlists { get; set; }

    }
}