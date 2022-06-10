using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumPrzykladowe.Entities.Configuration
{
    public class MusicLabelEfConfiguration : IEntityTypeConfiguration<MusicLabel>
    {

        public void Configure(EntityTypeBuilder<MusicLabel> builder)
        {
            builder.HasKey(e => e.IdMusicLabel).HasName("MusicLabel_pk");
            builder.Property(e => e.IdMusicLabel).UseIdentityColumn();
            builder.Property(e => e.Name).UseIdentityColumn();

            IEnumerable<MusicLabel> musicians = new List<MusicLabel>
            {
                new MusicLabel
                {
                    IdMusicLabel = 1,
                    Name = "asd"
                }
            };

            builder.HasData(musicians);
            builder.ToTable("MusicLabels");

        }
    }
}
