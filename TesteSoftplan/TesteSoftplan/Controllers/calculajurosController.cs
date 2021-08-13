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
    public class calculajurosController : ControllerBase
    {
        IJurosService service;
        public calculajurosController(IJurosService service)
        {
            this.service = service;
        }
       
        [HttpGet]
        public void calcularJuros()
        {            
        }        
        
        [HttpPost]
        public string calcularJuros([FromBody] Juros juros)
        {
            return service.calculoJ(juros);
        }             

        
    }
}
