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
    public class ParticipanteController : ControllerBase
    {
        private readonly IParticipanteService _participanteService;

        public ParticipanteController(IParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

      
        [HttpGet("filtered-count")]
        public async Task<IActionResult> GetFilteredParticipanteCount()
        {
            try
            {
              
                var count = await _participanteService.GetFilteredParticipanteCountAsync();
                return Ok(count);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


        // GET: api/participantes/count
        [HttpGet("count")]
        public async Task<IActionResult> GetDoctoralCandidatesCount()
        {
            try
            {
                var count = await _participanteService.CountAsync();
                return Ok(count); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        // GET: api/participantes/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParticipanteById(int id)
        {
            try
            {
                var participante = await _participanteService.FindByIdAsync(id);
                return Ok(participante); 
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

        // GET: api/participantes
        [HttpGet]
        public async Task<IActionResult> GetAllParticipantes()
        {
            try
            {
                var participantes = await _participanteService.GetAllAsync();
                return Ok(participantes);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
