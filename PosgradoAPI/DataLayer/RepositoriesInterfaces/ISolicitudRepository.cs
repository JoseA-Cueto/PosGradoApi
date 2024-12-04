using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepoBase;

namespace PosgradoAPI.DataLayer.RepositoriesInterfaces
{
    public interface ISolicitudRepository : IRepositoryBase<Solicitud>
    {
        Task<int> GetDoctoralProgramFacultyCount();
        Task<int> GetFilteredSolicitudesCountAsync();
    }
}
