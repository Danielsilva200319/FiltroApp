using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("insumoPrenda");

            builder.HasOne(p => p.Insumos)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.IdInsumo);

            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.IdPrenda);

            builder.Property(p => p.Cantidad)
            .HasColumnType("int");
        }
    }
}