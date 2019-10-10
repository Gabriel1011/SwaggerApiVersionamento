using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerApiVersionamento.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiversion}")]
    [ApiController]
    public class TesteController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Testes()
        {
            return Ok("Versão 2");
        }
    }
}