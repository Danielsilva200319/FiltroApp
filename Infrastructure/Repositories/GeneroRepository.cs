using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructura.Data;

namespace Infrastructure.Repositories
{
    public class GeneroRepository : GenericRepository<Genero>
    {
        private readonly daniels_ropaContext _context;

        public GeneroRepository(daniels_ropaContext context) : base(context)
        {
            _context = context;
        }
    }
}