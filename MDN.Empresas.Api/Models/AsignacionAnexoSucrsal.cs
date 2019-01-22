using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class AsignacionAnexoSucrsal
    {
        public string Id { get; set; }
        public int CodigoSucursal { get; set; }

        /*Relaciones y Navegación*/
        public EmpresaAnexo EmpresaAnexo { get; set; }
        public IEnumerable<EjecutivoEncargado> EjecutivosEncargados { get; set; }
    }
}
