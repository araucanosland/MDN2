using MDN.Dotacion.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Repositories
{
    public interface IDotacionAsignada
    {
        DotacionAsignada obtenerPorId(string id);

        IEnumerable<DotacionAsignada> listarPorPeriodo(int periodo);

        /*Debe obtener todo lo del perido actual siempre*/
        IEnumerable<DotacionAsignada> listarPorRutEjecutivo(string rut);

        /*Se debe manejar aca la busqueda por un periodo en particular*/
        IEnumerable<DotacionAsignada> listarPorRutEjecutivoYPeriodo(string rut, int periodo);
        
        /*Con Periodo Actual*/
        IEnumerable<DotacionAsignada> listarPorSucursal(int codigoSucursal);

        /*Selecciona periodo*/
        IEnumerable<DotacionAsignada> listarPorSucursalYPeriodo(int codigoSucursal, int periodo);

        void insertarNuevo(DotacionAsignada entrada);

        void actualizarExistente(DotacionAsignada entrada);
    }
}
