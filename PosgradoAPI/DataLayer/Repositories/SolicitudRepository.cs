using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class SolicitudRepository : RepositoryBase<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(AppDbContext context) : base(context)
        {
        }
    }
}
