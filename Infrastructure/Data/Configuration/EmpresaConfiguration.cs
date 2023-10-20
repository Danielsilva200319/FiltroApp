using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(P => P.Nit)
            .IsUnique();

            builder.Property(p => p.RazonSocial)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(p => p.FechaCreacion)
            .HasColumnType("date");

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Empresas)
            .HasForeignKey(p => p.IdMunicipio);
        }
    }
}