using System;
using System.Reflection;
using KolokwiumPrzykladowe.Entities.Configuration;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPrzykladowe.Entities
{
    public class MusicContext : DbContext
    {
        public MusicContext()
        {
        }

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }


        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Musican_Track> Musican_Tracks { get; set; }
        public virtual DbSet<Musician> Musicians { get; set; }
        public virtual DbSet<MusicLabel> MusicLabels { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(TrackEfConfiguration).GetTypeInfo().Assembly);
        }
    }
}
