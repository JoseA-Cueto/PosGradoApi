using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.Enums;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface IProfessionalService
    {
        Task<IEnumerable<ProfessionalDto>> GetAllAsync();
        Task<ProfessionalDto> FindByIdAsync(int id);
        Task<int> CountByProgramTypeAndStatusAsync(ProgramType programType, ProfessionalType type);
        Task<int> CountProfessionalsInDoctorateProgramsAsync();
        Task<int> CountDoctorateProfessionalsInStrategicSectorsAsync();
        Task<int> CountDoctorateProfessionalsInLocalDevelopmentAsync();
        Task<int> CountProfessionalsInStrategicSectorsAsync();
        Task<int> CountProfessionalsAndProfessorsWithCardreAsync();
        Task<int> CountProfessionalsAndProfessorsWithTrainingAsync();
    }
}
