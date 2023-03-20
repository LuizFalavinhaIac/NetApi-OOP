using Microsoft.AspNetCore.Mvc;

namespace LG.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{
    private readonly ILogger<ClientesController> _logger;

    public ClientesController(ILogger<ClientesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var cliente = new Cliente("Fulano da Silva", "fulano@email.com", "14991234567", "Av. Paulista");
        cliente.AdicionarContato(10, "Contato 10", "012345", ETipoRelacionamentoContato.Pai);
        cliente.AdicionarContato(3, "Contato 3", "123456", ETipoRelacionamentoContato.Mae);
        cliente.AdicionarContato(1, "Contato 1", "234567", ETipoRelacionamentoContato.Irmao);
        cliente.AdicionarContato(5, "Contato 5", "345678", ETipoRelacionamentoContato.Amigo);
        cliente.AdicionarContato(7, "Contato 7", "456789", ETipoRelacionamentoContato.Outros);
        cliente.AdicionarContato(6, "Contato 6", "456789", ETipoRelacionamentoContato.Outros);
        
        return Ok(cliente);
    }
}
