using PosgradoAPI.Core.DTOs;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface IParticipanteService
    {
        Task<IEnumerable<SolicitudDTO>> GetAllAsync();
        Task<SolicitudDTO> FindByIdAsync(int id);
        Task<int> CountAsync();
        Task<int> GetFilteredParticipanteCountAsync();
        Task<int> ContarParticipantesConCuadroTrueAsync();
    }
}
