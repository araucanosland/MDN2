using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class Empresa
    {
        [Key]
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Holding { get; set; }
        public string Segmento { get; set; }

        /*Navegacion y relaciones*/
        public IEnumerable<EmpresaAnexo> Anexos { get; set; }
    }
}
