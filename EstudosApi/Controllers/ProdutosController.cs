using System.Reflection.Metadata.Ecma335;
using EstudosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : Controller
{
   [HttpPost]
   public IActionResult Cadastrar(Produto produto)
    {
        return Ok(new
        {
            mensagem = "Produto cadastro com sucesso",
            dados = produto
        });
    }
}
