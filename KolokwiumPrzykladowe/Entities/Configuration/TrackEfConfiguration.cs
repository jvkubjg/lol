using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumPrzykladowe.Entities.Configuration
{
    public class TrackEfConfiguration : IEntityTypeConfiguration<Track>
    {

        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(e => e.IdTrack).HasName("Track_pk");
            builder.Property(e => e.IdTrack).UseIdentityColumn();

   
            builder.Property(e => e.TrackName).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Duration).IsRequired();

            builder.HasOne(e => e.IdAlbumNavigation)
                 .WithMany(e => e.Tracks)
                 .HasForeignKey(e => e.IdMusicAlbum)
                 .HasConstraintName("track_music")
                 .OnDelete(DeleteBehavior.ClientSetNull);



            IEnumerable<Track> musicians = new List<Track>
            {
                new Track
                {
                 IdTrack =1,
                 TrackName = "Asd",
                 Duration = 1.0f,
                 IdMusicAlbum = 1,
                },
                       new Track
                {
                 IdTrack =2,
                 TrackName = "Asd",
                 Duration = 1.5f,
                 IdMusicAlbum = 1,
                },

            };

            builder.HasData(musicians);
            builder.ToTable("Tracks");
        }
    }
}
