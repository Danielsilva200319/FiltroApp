using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("insumoProveedor");

            builder.HasOne(p => p.Insumos)
            .WithMany(p => p.InsumoProveedores)
            .HasForeignKey(p => p.IdInsumo);

            builder.HasOne(p => p.Proveerdores)
            .WithMany(p => p.InsumoProveedores)
            .HasForeignKey(p => p.IdProveedor);
        }
    }
}