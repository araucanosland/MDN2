using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDN.Dotacion.Api.Models;

namespace MDN.Dotacion.Api.Repositories
{
    public class DotacionAutorizadaImpl : IDotacionAutorizada
    {
        public void actualizarExistente(DotacionAutorizada entrada)
        {
            throw new NotImplementedException();
        }

        public void insertarNueva(DotacionAutorizada entrada)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAutorizada> listarPorSucursal(int codigoSucursal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAutorizada> listarPorSucursalYCargo(int codigoSucursal, string cargo)
        {
            throw new NotImplementedException();
        }

        public DotacionAutorizada obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
