using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSoftplan.Data;
using TesteSoftplan.Services;

namespace TesteSoftplan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class taxaJurosController : ControllerBase
    {
        IJurosService service;
        public taxaJurosController(IJurosService service)
        {
            this.service = service;
        }


        [HttpGet]
        public decimal taxaJuros()
        {            
            return service.mostrarJ();
        }
    }
}
