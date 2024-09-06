using Microsoft.AspNetCore.Mvc;
using ProdutoCodigo.Models;
using System.Collections.Generic;

namespace ProdutoCodigo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> codigoProdutos = new List<Produto>();

        [HttpPost("RegistroCodigo")]
        public IActionResult RegistroCodigo([FromBody] Produto produto)
        {
            const string numeros = "1234567890";

            if (produto.codigoProduto.StartsWith("AAA-"))
            {
                for (int i = 4; i < produto.codigoProduto.Length; i++)
                {
                    if (numeros.IndexOf(produto.codigoProduto[i]) < 0)
                    {
                        return BadRequest("Codigo Produto Invalido");
                    }
                }

                codigoProdutos.Add(produto);
                return Ok("Produto registrado");
            }

            return BadRequest("Codigo Produto Invalido");
        }
    }
}
