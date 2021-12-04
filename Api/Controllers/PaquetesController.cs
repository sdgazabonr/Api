using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Api.Bussines;

namespace Api.Controllers
{
    [ApiController]
    
    public class PaquetesController : ControllerBase
    {

        [HttpGet]
        [Route("/paquetes")]
        public IActionResult GetPaquetes(Paquete body)
        {
            try
            {
                PaqueteBL paqueteBL = new PaqueteBL();
                PaqueteResponse response = paqueteBL.GetPaquete(body);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }
    }
}
