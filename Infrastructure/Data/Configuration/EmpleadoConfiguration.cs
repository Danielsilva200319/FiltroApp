using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleado");

            builder.HasIndex(p => p.IdEmp)
            .IsUnique();

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.HasOne(p => p.Cargos)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdCargo);

            builder.Property(p => p.FechaIngreso)
            .HasColumnType("date");

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdMunicipio);
        }
    }
}