using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructura.Data;

namespace Infrastructure.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>
    {
        private readonly daniels_ropaContext _context;

        public ClienteRepository(daniels_ropaContext context) : base(context)
        {
            _context = context;
        }
    }
}