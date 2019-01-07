using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Models
{
    public class EmpresaProspecto
    {
        [Key]
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Region { get; set; }
        public string Comuna { get; set; }
        public string Direccion { get; set; }
        public string CajaOrigen { get; set; }
        public int CantidadTrabajadores { get; set; }
        public string Rubro { get; set; }
        public string Segmento { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Oficina { get; set; }
        public string Ejecutivo { get; set; }
        public string RutHolding { get; set; }
        public string NombreHolding { get; set; }

        /*Navegacion*/
        public IEnumerable<EmpresaProspectoContacto> Contactos { get; set; }
        public IEnumerable<EmpresaProspectoGestion> Gestiones { get; set; }


    }
}
