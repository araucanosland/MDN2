using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDN.Dotacion.Api.Models;

namespace MDN.Dotacion.Api.Repositories
{
    public class DotacionAsignadaImpl : IDotacionAsignada
    {
        public void actualizarExistente(DotacionAsignada entrada)
        {
            throw new NotImplementedException();
        }

        public void insertarNuevo(DotacionAsignada entrada)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAsignada> listarPorPeriodo(int periodo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAsignada> listarPorRutEjecutivo(string rut)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAsignada> listarPorRutEjecutivoYPeriodo(string rut, int periodo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAsignada> listarPorSucursal(int codigoSucursal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DotacionAsignada> listarPorSucursalYPeriodo(int codigoSucursal, int periodo)
        {
            throw new NotImplementedException();
        }

        public DotacionAsignada obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
