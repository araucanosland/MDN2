using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Models
{
    public class DotacionAutorizada
    {
        public string Id { get; set; }
        public int Sucursal { get; set; }
        public string Cargo { get; set; }
        public DateTime CreadoEn { get; set; }
        public DateTime? ModificadoEn { get; set; }
    }
}
