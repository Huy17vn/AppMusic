using Microsoft.EntityFrameworkCore;
using MusicApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public class MyDbcontex : DbContext

    {
        public List<SongCategory> SongCategories { get; set; }

        public List<Song> Songs { get; set; }

        public List<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ListSong;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongCategory>()
                .HasKey(sc => new { sc.SongID, sc.CategoryID });
        }

        public DbSet<MusicApplication.Models.Song> Song { get; set; }

        public DbSet<MusicApplication.Models.Category> Category { get; set; }
    }
}
