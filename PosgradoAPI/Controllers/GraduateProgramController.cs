using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;

namespace PosgradoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraduateProgramController : ControllerBase
    {
        private readonly IGraduateProgramService _service;

        public GraduateProgramController(IGraduateProgramService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GraduateProgramDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GraduateProgramDto>> GetById(int id)
        {
            var result = await _service.FindByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("count-programs-strategic-sectors")]
        public async Task<ActionResult<int>> GetCountProgramsInStrategicSectors()
        {
            var count = await _service.CountStrategicSectorProgramsAsync();
            return Ok(count);
        }

        [HttpGet("count-programs-local-development")]
        public async Task<ActionResult<int>> GetCountProgramsInLocalDevelopment()
        {
            var count = await _service.CountLocalDevelopmentProgramsAsync();
            return Ok(count);
        }
        [HttpGet("percentage/distance")]
        public async Task<ActionResult<double>> GetPercentageOfDistancePrograms()
        {
            var percentage = await _service.CalculatePercentageOfDistanceProgramsAsync();
            return Ok(percentage);
        }
        [HttpGet("percentage/superior-accreditation")]
        public async Task<ActionResult<double>> GetPercentageOfSuperiorAccreditedPrograms()
        {
            var percentage = await _service.CalculatePercentageOfSuperiorAccreditedProgramsAsync();
            return Ok(percentage);
        }


    }
}
