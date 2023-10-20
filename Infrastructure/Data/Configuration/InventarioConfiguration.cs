using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.CodInv)
            .IsUnique();

            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.Inventarios)
            .HasForeignKey(p => p.IdPrenda);

            builder.Property(p => p.ValorVtaCop)
            .HasColumnType("double");

            builder.Property(p => p.ValorVtaUsd)
            .HasColumnType("double");
        }
    }
}