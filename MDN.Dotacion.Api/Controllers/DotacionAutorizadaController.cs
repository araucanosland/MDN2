using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDN.Dotacion.Api.Models;
using MDN.Dotacion.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MDN.Dotacion.Api.Controllers
{
    [Route("api/dotacion-autorizada")]
    [ApiController]
    public class DotacionAutorizadaController : ControllerBase
    {
        private readonly IDotacionAutorizada _dotacionAutorizadaRepository; 

        public DotacionAutorizadaController(IDotacionAutorizada dotacionAutorizada)
        {
            _dotacionAutorizadaRepository = dotacionAutorizada;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{codigoSucursal}")]
        public ActionResult<IEnumerable<DotacionAutorizada>> Get(int codigoSucursal)
        {
            return Ok(_dotacionAutorizadaRepository.listarPorSucursal(codigoSucursal));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] dynamic entrada)
        {
           
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
