using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeaController : ControllerBase
{
    private static readonly string[] Teas = new[]
    {
        "Black Tea", "Ginger Tea", "Cardamom Tea", "Kulhad Tea", "Qahwa", "Green tea", "Masala Tea"
    };

    private readonly ILogger<TeaController> _logger;

    public TeaController(ILogger<TeaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
       var rng = new Random();
       return Ok(Teas[rng.Next(Teas.Length)]);

    }
}
