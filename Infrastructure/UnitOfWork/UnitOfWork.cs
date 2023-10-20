using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructura.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly daniels_ropaContext _context;

        public UnitOfWork(daniels_ropaContext context)
        {
            _context = context;
        }
        private CargoRepository _cargos;
        private ClienteRepository _clientes;
        private ColorRepository _colores;
        private DepartamentoRepository _departamentos;

        public ICargoRepository Cargos
        {
            get
            {
                if(_cargos == null)
                {
                    _cargos = new CargoRepository(_context);
                }
                return _cargos;
            }
        }

        public IClienteRepository Clientes
        {
            get
            {
                if(_clientes == null)
                {
                    _clientes = new ClienteRepository(_context);
                }
                return _clientes;
            }
        }

        public IColorRepository Colores
        {
            get
            {
                if(_colores == null)
                {
                    _colores = new ColorRepository(_context);
                }
                return _colores;
            }
        }

        public IDepartamentoRepository Departamentos
        {
            get
            {
                if(_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }
        }

        public IDetalleOrdenRepository DetalleOrdenes
        {
            get
            {
                if(_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }
        }

        public IDetalleVentaRepository DetalleVentas => throw new NotImplementedException();

        public IEmpleadoRepository Empleados => throw new NotImplementedException();

        public IEmpresaRepository Empresas => throw new NotImplementedException();

        public IEstadoRepository Estados => throw new NotImplementedException();

        public IFormaPagoRepository FormaPagos => throw new NotImplementedException();

        public IGeneroRepository Generos => throw new NotImplementedException();

        public IInsumoPrendaRepository InsumoPrendaS => throw new NotImplementedException();

        public IInsumoProveedorRepository InsumoProveedores => throw new NotImplementedException();

        public IInsumoRepository Insumos => throw new NotImplementedException();

        public IInventarioRepository Inventarios => throw new NotImplementedException();

        public IInventarioTallaRepository InventarioTallas => throw new NotImplementedException();

        public IMunicipioRepository Municipios => throw new NotImplementedException();

        public IOrdenRepository Ordenes => throw new NotImplementedException();

        public IPaisRepository Paises => throw new NotImplementedException();

        public IPrendaRepository Prendas => throw new NotImplementedException();

        public ITallaRepository Tallas => throw new NotImplementedException();

        public ITipoEstadoRepository TipoEstados => throw new NotImplementedException();

        public ITipoPersonaRepository TipoPersonas => throw new NotImplementedException();

        public ITipoProteccionRepository TipoProtecciones => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}