using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Models
{
    public class Colaborador
    {
        [Key]
        public string Rut { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        
    }
}
