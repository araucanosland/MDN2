using MDN.Dotacion.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Repositories
{
    public interface IDotacionAutorizada
    {
        DotacionAutorizada obtenerPorId(string id);
        IEnumerable<DotacionAutorizada> listarPorSucursal(int codigoSucursal);
        IEnumerable<DotacionAutorizada> listarPorSucursalYCargo(int codigoSucursal, string cargo);
        void insertarNueva(DotacionAutorizada entrada);
        void actualizarExistente(DotacionAutorizada entrada);
        
    }
}
