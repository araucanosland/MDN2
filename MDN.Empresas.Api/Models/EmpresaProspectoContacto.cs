using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class EmpresaProspectoContacto
    {
        public string Id { get; set; }
        public string TipoContacto { get; set; } //[Gerente Genrea, RRHH, Sindicato, ...etc]
        public string NombreContacto { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public int Oficina { get; set; }
        public string Ejecutivo { get; set; }
        public DateTime FechaIngreso { get; set; }
        
        /*Navegacion*/
        public EmpresaProspecto EmpresaProspecto { get; set; }

    }
}
