using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetMeInTheMood.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 8)]
        public string email { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 2)]
        public string username { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 8)]
        public string password { get; set; }

        public List<Playlist> Playlists { get; set; }

    }
}