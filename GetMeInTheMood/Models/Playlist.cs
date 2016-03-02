using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMeInTheMood.Models
{
    public class Playlist
    {
        public int ID { get; set; }

        public string Mood { get; set; }

        public string Name { get; set; }
    }
}