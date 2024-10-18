using Microsoft.AspNetCore.Mvc;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;

namespace PosgradoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThesisController : ControllerBase
    {
        private readonly IThesisService _service;

        public ThesisController(IThesisService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThesisDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ThesisDto>> GetById(int id)
        {
            var result = await _service.FindByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("count-defended-doctoral-theses")]
        public async Task<ActionResult<int>> GetCountDefendedDoctoralTheses()
        {
            var totalCount = await _service.CountTotalDefendedDoctoralThesesAsync();
            return Ok(totalCount);
        }
        [HttpGet("count-defended-doctoral-theses-strategic-sectors")]
        public async Task<ActionResult<int>> GetCountDefendedDoctoralThesesInStrategicSectors()
        {
            var count = await _service.CountDefendedDoctoralThesesInStrategicSectorsAsync();
            return Ok(count);
        }

        [HttpGet("count-defended-doctoral-theses-local-development")]
        public async Task<ActionResult<int>> GetCountDefendedDoctoralThesesInLocalDevelopment()
        {
            var count = await _service.CountDefendedDoctoralThesesInLocalDevelopmentAsync();
            return Ok(count);
        }
        [HttpGet("count-defended-master-theses-strategic-sectors")]
        public async Task<ActionResult<int>> GetCountDefendedMasterThesesInStrategicSectors()
        {
            var count = await _service.CountDefendedMasterThesesInStrategicSectorsAsync();
            return Ok(count);
        }
        [HttpGet("count-defended-master-theses-local-development")]
        public async Task<ActionResult<int>> GetCountDefendedMasterThesesInLocalDevelopment()
        {
            var count = await _service.CountDefendedMasterThesesInLocalDevelopmentAsync();
            return Ok(count);
        }
        [HttpGet("count-defended-specialty-theses-strategic-sectors")]
        public async Task<ActionResult<int>> GetCountDefendedSpecialtyThesesInStrategicSectors()
        {
            var count = await _service.CountDefendedSpecialtyThesesInStrategicSectorsAsync();
            return Ok(count);
        }
        [HttpGet("count-defended-specialty-theses-local-development")]
        public async Task<ActionResult<int>> GetCountDefendedSpecialtyThesesInLocalDevelopment()
        {
            var count = await _service.CountDefendedSpecialtyThesesInLocalDevelopmentAsync();
            return Ok(count);
        }


    }
}
