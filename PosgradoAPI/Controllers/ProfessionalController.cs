using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.BusinessLayer.Service;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Enums;

namespace PosgradoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalController : ControllerBase
    {
        private readonly IProfessionalService _service;

        public ProfessionalController(IProfessionalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessionalDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessionalDto>> GetById(int id)
        {
            var result = await _service.FindByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("count-by-program-type-and-status")]
        public async Task<ActionResult<int>> GetCountByProgramTypeAndStatus(ProgramType programType, ProfessionalType type)
        {
            var count = await _service.CountByProgramTypeAndStatusAsync(programType, type);
            return Ok(count);
        }

        [HttpGet("count-doctorate-professionals")]
        public async Task<ActionResult<int>> GetCountProfessionalsInDoctoratePrograms()
        {
            var count = await _service.CountProfessionalsInDoctorateProgramsAsync();
            return Ok(count);
        }

        [HttpGet("count-doctorate-professionals-in-strategic-sectors")]
        public async Task<ActionResult<int>> GetCountDoctorateProfessionalsInStrategicSectors()
        {
            var count = await _service.CountDoctorateProfessionalsInStrategicSectorsAsync();
            return Ok(count);
        }

        [HttpGet("count-doctorate-professionals-in-local-development")]
        public async Task<ActionResult<int>> CountDoctorateProfessionalsInLocalDevelopmentAsync()
        {
            var count = await _service.CountDoctorateProfessionalsInLocalDevelopmentAsync();
            return Ok(count);
        }
        [HttpGet("count-professionals-strategic-sectors")]
        public async Task<ActionResult<int>> GetCountProfessionalsInStrategicSectors()
        {
            var count = await _service.CountProfessionalsInStrategicSectorsAsync();
            return Ok(count);
        }
        [HttpGet("count/professionals-professors/training")]
        public async Task<ActionResult<int>> GetCountOfProfessionalsAndProfessorsWithTraining()
        {
            var count = await _service.CountProfessionalsAndProfessorsWithTrainingAsync();
            return Ok(count);
        }
        [HttpGet("count/professionals-professors/cadre")]
        public async Task<ActionResult<int>> CountProfessionalsAndProfessorsWithCardreAsync()
        {
            var count = await _service.CountProfessionalsAndProfessorsWithCardreAsync();
            return Ok(count);
        }

    }
}
