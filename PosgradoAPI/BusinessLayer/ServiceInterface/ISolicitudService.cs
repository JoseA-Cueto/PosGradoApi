using PosgradoAPI.Core.DTOs;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface ISolicitudService
    {
        Task<IEnumerable<SolicitudDTO>> GetAllAsync(); 
        Task<SolicitudDTO> FindByIdAsync(int id);
        Task<int> CountAsync(int idEstadoSolicitud);


    }
}
