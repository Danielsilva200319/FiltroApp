using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructura.Data;

namespace Infrastructure.Repositories
{
    public class ProveedorRepository : GenericRepository<Proveedor>
    {
        private readonly daniels_ropaContext _context;

        public ProveedorRepository(daniels_ropaContext context) : base(context)
        {
            _context = context;
        }
    }
}