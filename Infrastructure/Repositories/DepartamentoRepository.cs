using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructura.Data;

namespace Infrastructure.Repositories
{
    public class DepartamentoRepository : GenericRepository<Departamento>
    {
        private readonly daniels_ropaContext _context;

        public DepartamentoRepository(daniels_ropaContext context) : base(context)
        {
            _context = context;
        }
    }
}