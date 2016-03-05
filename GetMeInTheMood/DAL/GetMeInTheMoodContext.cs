using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GetMeInTheMood.Models;

namespace GetMeInTheMood.DAL
{
    public class GetMeInTheMoodContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Mood> Moods { get; set; }

    }
}