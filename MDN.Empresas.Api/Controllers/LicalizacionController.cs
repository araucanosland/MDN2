using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDN.Empresas.Api.Controllers
{
    [Route("api/localizacion")]
    [ApiController]
    public class LicalizacionController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;


        public LicalizacionController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        // GET api/localizacion
        [HttpGet]
        public IActionResult Get()
        {
            string contentRootPath = _hostingEnvironment.WebRootPath;
            var JSON = System.IO.File.ReadAllText(contentRootPath + "/regiones.json", Encoding.UTF8);
            return Ok(JSON);
        }
    }
}
