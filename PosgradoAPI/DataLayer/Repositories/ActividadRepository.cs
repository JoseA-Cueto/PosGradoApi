using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using System.Linq;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class ActividadRepository : RepositoryBase<Actividad>, IActividadRepository
    {
        public ActividadRepository(AppDbContext context) : base(context)
        {

        }
    }
}