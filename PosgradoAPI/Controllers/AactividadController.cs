using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;

namespace PosgradoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly IActividadService _actividadService;
        private readonly IMapper _mapper;

        public ActividadController(IActividadService actividadService, IMapper mapper)
        {
            _actividadService = actividadService;
            _mapper = mapper;
        }

        // GET: api/Actividad/count
        [HttpGet("count")]
        public async Task<IActionResult> CountAsync()
        {
            try
            {
                var count = await _actividadService.CountAsync();
                return Ok(count);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Actividad/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                var actividad = await _actividadService.FindByIdAsync(id);
                if (actividad == null)
                {
                    return NotFound($"Actividad with id {id} not found.");
                }
                return Ok(actividad);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Actividad
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var actividades = await _actividadService.GetAllAsync();
                return Ok(actividades);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("matricula-total-activa")]
        public async Task<IActionResult> ObtenerMatriculaTotalActiva()
        {
            try
            {
                var matriculaTotal = await _actividadService.ObtenerMatriculaTotalActivasAsync();
                return Ok(matriculaTotal);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        [HttpGet("matricula-total-fija")]
        public async Task<IActionResult> ObtenerMatriculaTotalFija()
        {
            try
            {
                var matriculaTotal = await _actividadService.ObtenerMatriculaTotalFijaAsync();
                if (matriculaTotal == null)
                {
                    return NotFound($"Actividad con id {2672} no encontrada.");
                }
                return Ok(matriculaTotal);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


    }
}
