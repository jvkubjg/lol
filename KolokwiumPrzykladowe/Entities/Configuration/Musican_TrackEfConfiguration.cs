using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumPrzykladowe.Entities.Configuration
{
    public class Musican_TrackEfConfiguration : IEntityTypeConfiguration<Musican_Track>
    {
   
        public void Configure(EntityTypeBuilder<Musican_Track> builder)
        {
            builder.HasKey(e => new { e.IdTrack, e.IdMusician}).HasName("MusicianTrack_pk");

            builder.HasOne(e => e.IdMusiciankNavigation).
                WithMany(e => e.musician_tracks)
                .HasForeignKey(e => e.IdMusician).
                HasConstraintName("MusicianTrack_musican")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.IdTrackNavigation).
                WithMany(e => e.musician_tracks)
                .HasForeignKey(e => e.IdTrack).
                HasConstraintName("MusicianTrack_track")
                .OnDelete(DeleteBehavior.ClientSetNull);




            IEnumerable<Musican_Track> musicians = new List<Musican_Track>
            {
                new Musican_Track
                {
                   IdTrack = 1,
                   IdMusician = 1
                }
            };

            builder.HasData(musicians);
            builder.ToTable("Musican_Tracks"); 
        }
    }
}
