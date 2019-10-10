using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SwaggerApiVersionamento.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("Teste/v{version:apiversion}")]
    [ApiController]
    public class VersionamentoController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Teste()
        {
            return Ok("Versão 2");
        }
    }
}