using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(): base("name=Netflix2.0")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Watchlist> Watchlists { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<TvShow> TvShows { get; set; }
        public virtual DbSet<Preference> Preferences { get; set; }
        public virtual DbSet<ContentGenre> ContentGenres { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}