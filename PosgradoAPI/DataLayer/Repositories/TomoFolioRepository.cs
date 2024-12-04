using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class TomoFolioRepository : RepositoryBase<TomoFolio>, ITomoFolioRepository
    {
        public TomoFolioRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<int> GetFilteredTomoFolioCountAsync()
        {
            try
            {
                const int idActividad = 3033;

                
                var count = await _context.TomoFolio
                    .Where(t => t.id_actividad == idActividad)
                    .CountAsync();  

                return count;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al contar los TomoFolio con los filtros especificados.", ex);
            }
        }


    }
}
