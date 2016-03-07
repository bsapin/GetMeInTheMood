using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMeInTheMood.Models
{
    public class Mood
    {
        public int ID { get; set; }
    
        public string name { get; set; }

        public string imageUrl { get; set; }

        public List<Playlist> Playlists { get; set; }
    }
}