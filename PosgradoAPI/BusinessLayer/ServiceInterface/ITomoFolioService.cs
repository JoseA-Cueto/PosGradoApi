using PosgradoAPI.Core.DTOs;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface ITomoFolioService
    {
        Task<IEnumerable<TomoFolioDTO>> GetAllAsync();
        Task<TomoFolioDTO> FindByIdAsync(int id);
        Task<int> GetFilteredTomoFolioCountAsync();

    }
}
