using Microsoft.AspNetCore.Mvc;

namespace LG.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculosController : ControllerBase
{
    private readonly ILogger<VeiculosController> _logger;

    public VeiculosController(ILogger<VeiculosController> logger)
    {
        _logger = logger;
    }

    [HttpGet("tipo/{tipo}")]
    public IActionResult Get(
        [FromServices] ServicoDeCarro servicoDeCarro, 
        [FromServices] ServicoDeCaminhao servicoDeCaminhao,
        ETipoVeiculo tipo
    )
    {
        if (tipo == ETipoVeiculo.CARRO) {
            servicoDeCarro.InsiraVeiculo(new Carro(1, "Carro 1", "ABC123", 5));
            servicoDeCarro.InsiraVeiculo(new Carro(2, "Carro 2", "DEF456", 5));
            servicoDeCarro.InsiraVeiculo(new Carro(3, "Carro 3", "GHI789", 5));

            return Ok(servicoDeCarro.ObtenhaListaDeVeiculos());
        }
        
        if (tipo == ETipoVeiculo.CAMINHAO) {
            servicoDeCaminhao.InsiraVeiculo(new Caminhao(1, "Caminhao 1", "ABC123", "001122", 2));
            servicoDeCaminhao.InsiraVeiculo(new Caminhao(2, "Caminhao 2", "DEF456", "112233", 4));
            servicoDeCaminhao.InsiraVeiculo(new Caminhao(3, "Caminhao 3", "GHI789", "223366", 6));

            return Ok(servicoDeCaminhao.ObtenhaQuantidadeDeVeiculos());
        }

        return Ok("Tipo nao encontrado");
    }
}