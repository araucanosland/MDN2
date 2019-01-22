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

        //Cartera de Empresas
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaAnexo> EmpresaAnexos { get; set; }
        public DbSet<AsignacionAnexoSucrsal> AsignacionesAnexoSucursal { get; set; }
        public DbSet<EjecutivoEncargado> EjecutivosEncargados { get; set; }

        public DbSet<EntidadEmpresarial> EntidadesEmpresariales { get; set; }

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
