using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TallaConfiguration : IEntityTypeConfiguration<Talla>
    {
        public void Configure(EntityTypeBuilder<Talla> builder)
        {
            builder.ToTable("talla");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(P => P.Descripcion)
            .IsRequired()
            .HasMaxLength(10);
        }
    }
}