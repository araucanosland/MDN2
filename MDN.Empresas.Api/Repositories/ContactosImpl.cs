using MDN.Empresas.Api.Data;
using MDN.Empresas.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Repositories
{
    public class ContactosImpl : IContactos
    {
        private readonly EmpresasDBContext _context;

        public ContactosImpl(EmpresasDBContext context)
        {
            _context = context;
        }

        public void agregarNuevo(EmpresaProspectoContacto contacto)
        {
            _context.EmpresaProspectoContactos.Add(contacto);
            _context.SaveChanges();
        }

        public IEnumerable<EmpresaProspectoContacto> listarPorEmpresa(string rut)
        {
            return _context.EmpresaProspectoContactos.Include(cn => cn.EmpresaProspecto).Where(cn => cn.EmpresaProspecto.Rut == rut).ToList();
        }

        public IEnumerable<EmpresaProspectoContacto> listarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
