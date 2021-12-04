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
    // [Route("[controller]")]
    public class CasasController : ControllerBase
    {

        [HttpGet]
        [Route("/casas")]
        public IActionResult GetCasas(Casas body)
        {
            try
            {
                CasasBL casasBL = new CasasBL();
                CasasResponse response = casasBL.GetCasas(body);
                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }
    }
}
