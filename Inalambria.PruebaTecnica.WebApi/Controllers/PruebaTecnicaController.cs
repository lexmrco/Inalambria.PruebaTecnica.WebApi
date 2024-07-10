using Inalambria.PruebaTecnica.WebApi.Models;
using Inalambria.PruebaTecnica.WebApi.Negocios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inalambria.PruebaTecnica.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaTecnicaController : ControllerBase
    {
        private readonly ILogger<PruebaTecnicaController> _logger;

        public PruebaTecnicaController(ILogger<PruebaTecnicaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] SolicitudModel solicitud)
        {
            try
            {
                ConvertirNumero convertirNumero = new ConvertirNumero();
                RespuestaModel respuestaModel  = new RespuestaModel();
                if(!double.TryParse(solicitud.Numero, out double numero))
                    return BadRequest("Error convirtiendo a número");
                respuestaModel.NumeroEnLetras =  convertirNumero.NumeroEnLetras(numero);
                return Ok(respuestaModel);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
