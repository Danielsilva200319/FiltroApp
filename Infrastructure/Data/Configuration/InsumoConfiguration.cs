using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("insumo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.Nombre)
            .IsUnique();

            builder.Property(e => e.ValorUnit)
            .HasColumnType("double");

            builder.Property(p => p.StockMin)
            .HasColumnType("int");

            builder.Property(p => p.StockMax)
            .HasColumnType("int");
        }
    }
}