using Microsoft.AspNetCore.Mvc;

namespace NET_6API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet("dummy")]
    public IEnumerable<string> Get()
    {
        return Enumerable.Range(1, 5).Select(index => $"index = {index}")
        .ToArray();
    }

    [HttpGet("dummy2")]
    public IEnumerable<string> Get2()
    {
        return Enumerable.Range(1, 5).Select(index => $"index = {index}")
        .ToArray();
    }
}
