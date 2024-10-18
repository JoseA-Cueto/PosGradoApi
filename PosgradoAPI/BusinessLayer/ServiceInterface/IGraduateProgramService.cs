using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface IGraduateProgramService
    {
        Task<IEnumerable<GraduateProgramDto>> GetAllAsync();
        Task<GraduateProgramDto> FindByIdAsync(int id);
        Task<int> CountStrategicSectorProgramsAsync();
        Task<int> CountLocalDevelopmentProgramsAsync();
        Task<double> CalculatePercentageOfDistanceProgramsAsync();
        Task<double> CalculatePercentageOfSuperiorAccreditedProgramsAsync();
    }
}
