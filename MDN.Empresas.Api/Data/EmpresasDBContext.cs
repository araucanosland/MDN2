using MDN.Empresas.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Data
{
    public class EmpresasDBContext : DbContext
    {
       
        //Prospectos
        public DbSet<EmpresaProspecto> EmpresasProspecto { get; set; }
        public DbSet<EmpresaProspectoContacto> EmpresaProspectoContactos { get; set; }
        public DbSet<EmpresaProspectoGestion> EmpresasProspectoGestiones { get; set; }


        public EmpresasDBContext(DbContextOptions<EmpresasDBContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("empresas");
        }
    }
}
