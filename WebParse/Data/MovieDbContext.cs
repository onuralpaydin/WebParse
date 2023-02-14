using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebParse.Models;

namespace WebParse.Data
{
    internal class MovieDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANK3-YZLMORT-08\\SQLEXPRESS;Database=MoviesAndStarsDB;User Id=sa;Password=sa; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Film>().Property(x => x.imdbPuanı).HasPrecision(2, 1); // decimal (2,1) görevini görür
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Film>().HasData(new Film { Ad = "loren", ID = 1 });
            //modelBuilder.Entity<Oyuncu>().HasData(new Oyuncu { AdSoyAd = "onurKöse", Id = 1 });

        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgileri { get; set; }
        public DbSet<Tur> Turler { get; set; }
    }

}
