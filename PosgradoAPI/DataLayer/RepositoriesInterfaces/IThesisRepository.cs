using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepoBase;

namespace PosgradoAPI.DataLayer.RepositoriesInterfaces
{
    public interface IThesisRepository : IRepositoryBase<Thesis>
    {
        Task<int> CountDefendedDoctoralThesesByProfessionalsAsync();
        Task<int> CountDefendedDoctoralThesesByFullTimeProfessorsAsync();
        Task<int> CountDefendedDoctoralThesesInStrategicSectorsAsync();
        Task<int> CountDefendedDoctoralThesesInLocalDevelopmentAsync();
        Task<int> CountDefendedMasterThesesInStrategicSectorsAsync();
        Task<int> CountDefendedMasterThesesInLocalDevelopmentAsync();
        Task<int> CountDefendedSpecialtyThesesInStrategicSectorsAsync();
        Task<int> CountDefendedSpecialtyThesesInLocalDevelopmentAsync();
    }
}
