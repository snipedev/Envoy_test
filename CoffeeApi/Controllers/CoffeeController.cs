using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeController : ControllerBase
{

    private readonly ILogger<CoffeeController> _logger;

    public CoffeeController (ILogger<CoffeeController> logger)
    {
        _logger = logger;
    }

    private static readonly string[] Coffees = new[]
    {
        "Capuccino" , "Long Black", "Latte" ,"Americano", "Mocha"
    };

    [HttpGet]
    public ActionResult Get()
    {
        var rng = new Random();
        return Ok(Coffees[rng.Next(Coffees.Length)]);
    }
}
