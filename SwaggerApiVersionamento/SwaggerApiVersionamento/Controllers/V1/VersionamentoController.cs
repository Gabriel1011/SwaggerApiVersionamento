using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerApiVersionamento.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("Teste/v{version:apiversion}")]
    [ApiController]
    public class VersionamentoController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Teste()
        {
            return Ok("Versão 1");
        }
    }
}