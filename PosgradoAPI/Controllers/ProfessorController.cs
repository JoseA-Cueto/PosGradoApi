using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
namespace PosgradoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _service;

        public ProfessorController(IProfessorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessorDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessorDto>> GetById(int id)
        {
            var result = await _service.FindByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("count-full-time-professors")]
        public async Task<ActionResult<int>> GetCountFullTimeProfessors()
        {
            var count = await _service.CountFullTimeProfessorsAsync();
            return Ok(count);
        }
        [HttpGet("percentage-doctors-directing")]
        public async Task<ActionResult<double>> GetPercentageOfDirectingDoctors()
        {
            var percentage = await _service.CalculatePercentageOfDirectingDoctorsAsync();
            return Ok(percentage);
        }
        [HttpGet("count/masters-specialists")]
        public async Task<ActionResult<int>> CountGraduatedMastersOrSpecialists()
        {
            var count = await _service.CountGraduatedMastersOrSpecialistsAsync();
            return Ok(count);
        }


    }
}
