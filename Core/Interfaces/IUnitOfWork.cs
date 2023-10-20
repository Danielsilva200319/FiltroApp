using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICargoRepository Cargos { get; set; }
        IClienteRepository Clientes { get; set; }
        IColorRepository Colores { get; set; }
        IDepartamentoRepository Departamentos { get; set; }
        IDetalleOrdenRepository DetalleOrdenes { get; set; }
        IDetalleVentaRepository DetalleVentas { get; set; }
        IEmpleadoRepository Empleados { get; set; }
        IEmpresaRepository Empresas { get; set; }
        IEstadoRepository Estados { get; set; }
        IFormaPagoRepository FormaPagos { get; set; }
        IGeneroRepository Generos { get; set; }
        IInsumoPrendaRepository InsumoPrendaS { get; set; }
        IInsumoProveedorRepository InsumoProveedores { get; set; }
        IInsumoRepository Insumos { get; set; }
        IInventarioRepository Inventarios { get; set; }
        IInventarioTallaRepository InventarioTallas { get; set; }
        IMunicipioRepository Municipios { get; set; }
        IOrdenRepository Ordenes { get; set; }
        IPaisRepository Paises { get; set; }
        IPrendaRepository Prendas { get; set; }
        ITallaRepository Tallas { get; set; }
        ITipoEstadoRepository TipoEstados { get; set; }
        ITipoPersonaRepository TipoPersonas { get; set; }
        ITipoProteccionRepository TipoProtecciones { get; set; }
        Task<int> SaveAsync();
    }
}