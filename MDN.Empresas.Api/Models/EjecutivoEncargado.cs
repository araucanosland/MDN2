using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class EjecutivoEncargado
    {
        public string Id { get; set; }
        public string Rut { get; set; }
        public AsignacionAnexoSucrsal AsignacionAnexoSucrsal { get; set; }

    }
}
