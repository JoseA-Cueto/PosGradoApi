using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using System.Linq;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class ParticipanteRepository : RepositoryBase<Participante>, IParticipanteRepository
    {
        public ParticipanteRepository(AppDbContext context) : base(context)
        {

        }
      
        public async Task<int> GetFilteredParticipanteCountAsync()
        {
            try
            {
                var gradoCientificoValores = new List<int> { 12, 13, 24 ,26};

                
                var count = await _context.Participante
                    .Where(p => gradoCientificoValores.Contains(p.id_grado_cientifico.Value))
                    .CountAsync();

                return count;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al contar los participantes filtrados.", ex);
            }
        }


    }
}
