using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class EmpresaProspectoGestion
    {
        public string Id { get; set; }
        public DateTime FechaGestion { get; set; }
        public DateTime FechaProximaGestion { get; set; }
        public string Etapa { get; set; }
        public string Comentarios { get; set; }

        /*Navegacion*/
        public EmpresaProspecto EmpresaProspecto { get; set; }

    }
}
