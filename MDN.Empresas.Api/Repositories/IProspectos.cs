using MDN.Empresas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Repositories
{
    public interface IProspectos
    {
        EmpresaProspecto buscarPorRut(string rut);

        void agregarNuevo(EmpresaProspecto prospecto);

        IEnumerable<EmpresaProspecto> listarPorOficina(int oficina);
        
        
    }
}
