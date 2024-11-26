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
        [HttpGet("count/{idEstadoSolicitud}")]
        public async Task<IActionResult> GetApprovedRequestCount(int idEstadoSolicitud)
        {
            try
            {
                var count = await _solicitudService.CountAsync(idEstadoSolicitud);
                return Ok(count);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
