using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface IThesisService
    {
        Task<IEnumerable<ThesisDto>> GetAllAsync();
        Task<ThesisDto> FindByIdAsync(int id);
        Task<int> CountTotalDefendedDoctoralThesesAsync();
        Task<int> CountDefendedDoctoralThesesInStrategicSectorsAsync();
        Task<int> CountDefendedDoctoralThesesInLocalDevelopmentAsync();
        Task<int> CountDefendedMasterThesesInStrategicSectorsAsync();
        Task<int> CountDefendedMasterThesesInLocalDevelopmentAsync();
        Task<int> CountDefendedSpecialtyThesesInStrategicSectorsAsync();
        Task<int> CountDefendedSpecialtyThesesInLocalDevelopmentAsync();
    }
}
