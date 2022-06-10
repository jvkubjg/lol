using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumPrzykladowe.Entities.Configuration
{
    public class MusicianEfConfiguration : IEntityTypeConfiguration<Musician>
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            builder.HasKey(e => e.IdMusician).HasName("Musician_pk");
            builder.Property(e => e.IdMusician).UseIdentityColumn();

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Nickanme).HasMaxLength(20);

            IEnumerable<Musician> musicians = new List<Musician>
            {
                new Musician
                {
                    IdMusician = 1,
                    FirstName = "asd",
                    LastName = "Asd",
                    Nickanme = "asdf"
                }
            };

            builder.HasData(musicians);
            builder.ToTable("Musician");
        }
    }
}
