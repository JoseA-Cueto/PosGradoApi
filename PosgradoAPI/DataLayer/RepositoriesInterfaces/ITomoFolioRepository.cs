using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepoBase;

namespace PosgradoAPI.DataLayer.RepositoriesInterfaces
{
    public interface ITomoFolioRepository : IRepositoryBase<TomoFolio>
    {
        Task<int> GetFilteredTomoFolioCountAsync();
    }
}
