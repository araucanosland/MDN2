using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class EntidadEmpresarial
    {
        public string Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Segmento { get; set; }
        public string Region { get; set; }
        public string Comuna { get; set; }
        public string Direccion { get; set; }
        public eTipoEntidad TipoEntidad { get; set; }
        public DateTime CreadoEl { get; set; }
        public DateTime? ModificadoEl { get; set; }


        public EntidadEmpresarial Padre { get; set; }
        public IEnumerable<EntidadEmpresarial> Hijos { get; set; }

    }

    public enum eTipoEntidad
    {
        Holding = 1,
        Empresa = 2,
        Sucursal = 3
    }
}
