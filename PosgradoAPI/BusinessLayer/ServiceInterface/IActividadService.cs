using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface IActividadService
    {
        Task<IEnumerable<ActividadDTO>> GetAllAsync();
        Task<ActividadDTO> FindByIdAsync(int id);
        Task<int> CountAsync();
        Task<int> ObtenerMatriculaTotalActivasAsync();
        Task<int?> ObtenerMatriculaTotalFijaAsync();

    }
}
