using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDN.Empresas.Api.Data;
using MDN.Empresas.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MDN.Empresas.Api.Repositories
{
    public class ProspectosImpl : IProspectos
    {

        private readonly EmpresasDBContext _context;

        public ProspectosImpl(EmpresasDBContext context)
        {
            _context = context;
        }

        public void agregarNuevo(EmpresaProspecto prospecto)
        {
            _context.EmpresasProspecto.Add(prospecto);
            _context.SaveChanges();
        }

        public EmpresaProspecto buscarPorRut(string rut)
        {
            return _context.EmpresasProspecto.Include(pros => pros.Contactos).FirstOrDefault(empresa => empresa.Rut == rut);
        }

        public IEnumerable<EmpresaProspecto> listarPorOficina(int oficina)
        {
            return _context.EmpresasProspecto.Where(x => x.Oficina == oficina).ToList();
        }
    }
}
