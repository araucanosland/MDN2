using MDN.Empresas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Repositories
{
    public interface IContactos
    {
        IEnumerable<EmpresaProspectoContacto> listarPorEmpresa(string rut);
        IEnumerable<EmpresaProspectoContacto> listarTodos();
        void agregarNuevo(EmpresaProspectoContacto contacto);
    }
}
