using System.Linq;
using Core.Extensions;
using Core.Models;
using Core.Util;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrafoController : Controller
    {
        [HttpGet]
        [Route("exemplo/desconexo")]
        public IActionResult ExemploDesconexo()
        {
            return Ok(Exemplos.GrafoDesconexo());
        }
        
        [HttpGet]
        [Route("exemplo/regular")]
        public IActionResult ExemploRegular()
        {
            return Ok(Exemplos.GrafoRegular());
        }
        
        [HttpGet]
        [Route("exemplo/completo")]
        public IActionResult ExemploCompleto()
        {
            return Ok(Exemplos.GrafoCompleto());
        }

        [HttpPost]
        [Route("conexo")]
        public IActionResult Conexo([FromBody] Grafo<int> grafo)
        {
            return Ok(grafo.Conexo());
        }
        
        [HttpPost]
        [Route("regular")]
        public IActionResult Regular([FromBody] Grafo<int> grafo)
        {
            return Ok(grafo.Regular());
        }
        
        [HttpPost]
        [Route("completo")]
        public IActionResult Completo([FromBody] Grafo<int> grafo)
        {
            return Ok(grafo.Completo());
        }

        [HttpPost]
        [Route("adjacentes")]
        public IActionResult Adjacentes(int valorVertice, [FromBody] Grafo<int> grafo)
        {
            return Ok(grafo.Vertices.First(v => v.Valor == valorVertice).Vizinhos.Select(v => v.Valor));
        }
        
    }
}