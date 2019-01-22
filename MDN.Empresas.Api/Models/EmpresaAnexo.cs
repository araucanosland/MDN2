using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class EmpresaAnexo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Region { get; set; }
        public string Comuna { get; set; }
        public string Direccion { get; set; }
        public bool EsMatriz { get; set; }
        public DateTime CreadoEn { get; set; }
        public DateTime? ModificadoEn { get; set; }
        
        /*Relaciones y navegacion*/
        public Empresa Empresa { get; set; }
        public IEnumerable<AsignacionAnexoSucrsal> Asignacion { get; set; }

    }
}
