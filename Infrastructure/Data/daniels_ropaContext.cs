using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Data
{
    public class daniels_ropaContext : DbContext
    {
        public daniels_ropaContext(DbContextOptions<daniels_ropaContext> options) : base(options)
        {
        }
        /* public DbSet<Auditoria> Auditorias { get; set; } */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public async Task<int> SaveChangeAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}