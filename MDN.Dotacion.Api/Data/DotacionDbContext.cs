using MDN.Dotacion.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Dotacion.Api.Data
{
    public class DotacionDbContext : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<DotacionAutorizada> DotacionAutorizadas { get; set; }
        public DbSet<DotacionAsignada> DotacionAsignadas { get; set; }
        public DbSet<Ausentismo> Ausentismos { get; set; }


        public DotacionDbContext(DbContextOptions<DotacionDbContext> options) 
            : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dotacion");
        }
    }
}
