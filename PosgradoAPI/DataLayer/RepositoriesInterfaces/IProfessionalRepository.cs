using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.Enums;

namespace PosgradoAPI.DataLayer.RepositoriesInterfaces
{
    public interface IProfessionalRepository : IRepositoryBase<Professional>
    {
        Task<int> CountByProgramTypeAndStatusAsync(ProgramType programType, ProfessionalType type);
        Task<int> CountProfessionalsInDoctorateProgramsAsync();
        Task<int> CountDoctorateProfessionalsInStrategicSectorsAsync();
         Task<int> CountDoctorateProfessionalsInLocalDevelopmentAsync();
        Task<int> CountProfessionalsInStrategicSectorsAsync();
        Task<int> CountProfessionalsWithTrainingAsync();
        Task<int> CountProfessionalInCadreAsync();
    }
}
