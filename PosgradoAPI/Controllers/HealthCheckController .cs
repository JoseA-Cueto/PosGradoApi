using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.DataBaseContext;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController : ControllerBase
{
    private readonly AppDbContext _context;

    public HealthCheckController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("check-database")]
    public IActionResult CheckDatabase()
    {
        try
        {

            _context.Database.CanConnect();

            return Ok(new { success = true, message = "Conexión exitosa a la base de datos." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { success = false, message = $"Error al conectar: {ex.Message}" });
        }
    }
}
