using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMeInTheMood.Models
{
    public class Playlist
    {
        public int ID { get; set; }

        public string name { get; set; }

        public User user { get; set; }

        public List<Song> songs { get; set; }

        public Mood mood { get; set; }

    }
}