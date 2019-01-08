using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Models
{
    public class MovimientoDotacion
    {
        public string Id { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public int SucursalOrigen { get; set; }
        public string CargoOrigen { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Comentarios { get; set; }
    }
}
