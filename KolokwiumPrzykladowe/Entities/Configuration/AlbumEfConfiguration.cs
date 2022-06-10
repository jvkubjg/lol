using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumPrzykladowe.Entities.Configuration
{
    public class AlbumEfConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.IdAlbum).HasName("Album_pk");
            builder.Property(e => e.IdAlbum).UseIdentityColumn();

            builder.Property(e => e.AlbumName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.PublishDate).IsRequired();


            builder.HasOne(e => e.IdMusicLabelNavigation)
                .WithMany(e => e.Albums)
                .HasForeignKey(e => e.idMusicLabel)
                .HasConstraintName("music_label_pk")
                 .OnDelete(DeleteBehavior.ClientSetNull);


            IEnumerable<Album> musicians = new List<Album>
            {
                new Album
                {
                    IdAlbum =1,
                    AlbumName = "Ad",
                    PublishDate = DateTime.Parse("1999-02-02"),
                    idMusicLabel = 1
                }
            };

            builder.HasData(musicians);
            builder.ToTable("Albums");
        }

    }
    }

