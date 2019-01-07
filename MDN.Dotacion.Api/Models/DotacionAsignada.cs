using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Models
{
    public class DotacionAsignada
    {
        public string Id { get; set; }
        public int Periodo { get; set; }
        public string TipoContrato { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string ReemplazoId { get; set; }
        public string Estado { get; set; }


        /*Relaciones y & Navegacion*/
        public Colaborador ColaboradorAsignado { get; set; }
        public DotacionAutorizada CargoAsignado { get; set; }


    }
}
