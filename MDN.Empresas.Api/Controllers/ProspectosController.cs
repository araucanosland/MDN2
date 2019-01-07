using MDN.Empresas.Api.Models;
using MDN.Empresas.Api.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Controllers
{
    [Route("api/prospectos")]
    [ApiController]
    
    public class ProspectosController : ControllerBase
    {
        private readonly IProspectos _prospectoRepository;
        

        public ProspectosController(IProspectos prospecto)
        {
            _prospectoRepository = prospecto;
        }

        // GET api/prospectos/88
        [HttpGet("{oficina}")]
        public ActionResult<IEnumerable<EmpresaProspecto>> Get(int oficina)
        {
            return Ok(_prospectoRepository.listarPorOficina(oficina));
        }

        [HttpGet("busqueda/{rut}")]
        public ActionResult<EmpresaProspecto> Get(string rut)
        {
            return Ok(_prospectoRepository.buscarPorRut(rut));
        }

        // POST api/prospectos
        [HttpPost]
        public ActionResult Post([FromBody] dynamic entrada)
        {
            try
            {
                string rutBuscar = entrada.rut;
                EmpresaProspecto oProspect = _prospectoRepository.buscarPorRut(rutBuscar);
                if (oProspect == null)
                {
                    oProspect = new EmpresaProspecto
                    {
                        Rut = (string)entrada.rut,
                        Nombre = (string)entrada.nombre,
                        CajaOrigen = (string)entrada.cajaOrigen,
                        CantidadTrabajadores = (int)entrada.cantidadTrabajadores,
                        Categoria = (string)entrada.categoria,
                        Region = (string)entrada.region,
                        Comuna = (string)entrada.comuna,
                        Direccion = (string)entrada.direccion,
                        Ejecutivo = (string)entrada.rutEjecutivo,
                        FechaIngreso = DateTime.Now,
                        NombreHolding = (string)entrada.nombreHolding,
                        Oficina = (int)entrada.oficinaCodigo,
                        Rubro = (string)entrada.rubro == "Otro" ? (string)entrada.otroRubro : (string)entrada.rubro,
                        RutHolding = (string)entrada.rutHolding,
                        Segmento = (string)entrada.segmento
                    };
                }
                
                if(entrada.contactos != null)
                {
                    List<EmpresaProspectoContacto> contactos = new List<EmpresaProspectoContacto>();

                    foreach (var contacto in entrada.contactos)
                    {
                        if(contacto.id == 0)
                        {
                            EmpresaProspectoContacto contact = new EmpresaProspectoContacto
                            {
                                Id = Guid.NewGuid().ToString(),
                                TipoContacto = (string)contacto.cargo,
                                FechaIngreso = DateTime.Now,
                                NombreContacto = (string)contacto.nombre,
                                Celular = (string)contacto.celular,
                                Email = (string)contacto.correo,
                                Telefono = (string)contacto.telefono,
                                Ejecutivo = (string)entrada.rutEjecutivo,
                                Oficina = (int)entrada.oficinaCodigo
                            };

                            contactos.Add(contact);
                        }
                       
                    }

                    oProspect.Contactos = contactos;
                }

                _prospectoRepository.agregarNuevo(oProspect);
               
                
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            
        }

        [HttpPut("{rut}")]
        public ActionResult Put([FromBody] dynamic entrada, [FromRoute] string rut)
        {
            if(entrada.rut == rut)
            {
                EmpresaProspecto oProspect = _prospectoRepository.buscarPorRut(rut);

                oProspect.Rut = (string)entrada.rut;
                oProspect.Nombre = (string)entrada.nombre;
                oProspect.CajaOrigen = (string)entrada.cajaOrigen;
                oProspect.CantidadTrabajadores = (int)entrada.cantidadTrabajadores;
                oProspect.Categoria = (string)entrada.categoria;
                oProspect.Region = (string)entrada.region;
                oProspect.Comuna = (string)entrada.comuna;
                oProspect.Direccion = (string)entrada.direccion;
                oProspect.Ejecutivo = (string)entrada.rutEjecutivo;
                oProspect.NombreHolding = (string)entrada.nombreHolding;
                oProspect.Oficina = (int)entrada.oficinaCodigo;
                oProspect.Rubro = (string)entrada.rubro == "Otro" ? (string)entrada.otroRubro : (string)entrada.rubro;
                oProspect.RutHolding = (string)entrada.rutHolding;
                oProspect.Segmento = (string)entrada.segmento;


                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
