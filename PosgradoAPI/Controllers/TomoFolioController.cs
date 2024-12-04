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
    public class TomoFolioController : ControllerBase
    {
        private readonly ITomoFolioService _tomoFolioService;

        public TomoFolioController(ITomoFolioService tomoFolioService)
        {
            _tomoFolioService = tomoFolioService;
        }

        // GET: api/tomofolio
        [HttpGet]
        public async Task<IActionResult> GetAllTomoFolios()
        {
            try
            {
                var tomoFolios = await _tomoFolioService.GetAllAsync();
                return Ok(tomoFolios); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        // GET: api/tomofolios/filtered-count
        [HttpGet("filtered-count")]
        public async Task<IActionResult> GetFilteredTomoFolioCount()
        {
            try
            {
                
                var count = await _tomoFolioService.GetFilteredTomoFolioCountAsync();
                return Ok(count);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


        // GET: api/tomofolio/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTomoFolioById(int id)
        {
            try
            {
                var tomoFolio = await _tomoFolioService.FindByIdAsync(id);
                return Ok(tomoFolio); 
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
    }
}
