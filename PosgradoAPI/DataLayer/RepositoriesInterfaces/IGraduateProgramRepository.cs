using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepoBase;

namespace PosgradoAPI.DataLayer.RepositoriesInterfaces
{
    public interface IGraduateProgramRepository : IRepositoryBase<GraduateProgram>
    {
        Task<int> CountProgramsInStrategicSectorsAsync();
        Task<int> CountProgramsInLocalDevelopmentAsync();
        Task<(int TotalPrograms, int DistancePrograms)> CountProgramsAsync();
        Task<(int TotalPrograms, int SuperiorAccreditedPrograms)> CountProgramsWithSuperiorAccreditationAsync();
    }
}
