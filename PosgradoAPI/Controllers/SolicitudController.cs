using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PosgradoAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly ISolicitudService _solicitudService;

        public SolicitudController(ISolicitudService solicitudService)
        {
            _solicitudService = solicitudService;
        }

        // GET: api/solicitudes
        [HttpGet]
        public async Task<IActionResult> GetAllRequests()
        {
            try
            {
                var solicitudes = await _solicitudService.GetAllAsync();
                return Ok(solicitudes);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        // GET: api/solicitudes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(int id)
        {
            try
            {
                var solicitud = await _solicitudService.FindByIdAsync(id);
                return Ok(solicitud);  
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        // GET: api/solicitudes/count/2
        [HttpGet("count")]
        public async Task<IActionResult> GetApprovedRequestCount()
        {
            try
            {
                var count = await _solicitudService.CountAsync();
                return Ok(count);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        // GET: api/solicitudes/doctoral-faculty-count
        [HttpGet("doctoral-faculty-count")]
        public async Task<IActionResult> GetDoctoralProgramFacultyCount()
        {
            try
            {
                var count = await _solicitudService.GetDoctoralProgramFacultyCountAsync();
                return Ok(count);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        // GET: api/solicitudes/filtered-count
        [HttpGet("filtered-count")]
        public async Task<IActionResult> GetFilteredSolicitudesCount()
        {
            try
            {
                // Llama al servicio para obtener el conteo filtrado
                var count = await _solicitudService.GetFilteredSolicitudesCountAsync();

                // Devuelve el resultado como respuesta exitosa
                return Ok(new { count });
            }
            catch (Exception ex)
            {
                // Captura cualquier error y devuelve un estado 500
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


    }
}
