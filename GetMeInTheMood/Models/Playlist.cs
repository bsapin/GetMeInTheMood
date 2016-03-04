using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMeInTheMood.Models
{
    public class Playlist
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

        public List<Song> Songs { get; set; }

        public Mood Mood { get; set; }

    }
}