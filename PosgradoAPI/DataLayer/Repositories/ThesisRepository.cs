using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using PosgradoAPI.Enums;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class ThesisRepository : RepositoryBase<Thesis>, IThesisRepository
    {
        public ThesisRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<int> CountDefendedDoctoralThesesByFullTimeProfessorsAsync()
        {
            return await _context.Thesis
                .Include(t => t.Professor)
                .Where(t => t.Type == ThesisType.Doctorate &&
                            t.Status == ThesisStatus.Defended &&
                            t.Professor.Type == ProfessorType.FullTime)                           
                         .CountAsync();
        }
        public async Task<int> CountDefendedDoctoralThesesByProfessionalsAsync()
        {
            return await _context.Thesis
                .Include(t => t.Professional)
                .Where(t => t.Type == ThesisType.Doctorate &&
                            t.Status == ThesisStatus.Defended &&
                            t.Professional is Professional) 
                .CountAsync();
        }

        public async Task<int> CountDefendedDoctoralThesesInStrategicSectorsAsync()
        {
            return await _context.Thesis
                .Where(t => t.Type == ThesisType.Doctorate &&
                            t.Status == ThesisStatus.Defended &&
                            t.IsStrategicSector) 
                .CountAsync();
        }

        public async Task<int> CountDefendedDoctoralThesesInLocalDevelopmentAsync()
        {
            return await _context.Thesis
                .Where(t => t.Type == ThesisType.Doctorate &&
                            t.Status == ThesisStatus.Defended &&
                            t.IsLocalDevelopment)
                .CountAsync();
        }
        public async Task<int> CountDefendedMasterThesesInStrategicSectorsAsync()
        {
            return await _context.Thesis
                .Where(t => t.Type == ThesisType.Master &&
                            t.Status == ThesisStatus.Defended &&
                            t.IsStrategicSector) 
                .CountAsync();
        }
        public async Task<int> CountDefendedMasterThesesInLocalDevelopmentAsync()
        {
            return await _context.Thesis
                .Where(t => t.Type == ThesisType.Master &&
                            t.Status == ThesisStatus.Defended &&
                            t.IsLocalDevelopment) 
                .CountAsync();
        }
        public async Task<int> CountDefendedSpecialtyThesesInStrategicSectorsAsync()
        {
            return await _context.Thesis
                .Where(t => t.Type == ThesisType.Specialty &&
                            t.Status == ThesisStatus.Defended &&
                            t.IsStrategicSector) 
                .CountAsync();
        }
        public async Task<int> CountDefendedSpecialtyThesesInLocalDevelopmentAsync()
        {
            return await _context.Thesis
                .Where(t => t.Type == ThesisType.Specialty &&
                            t.Status == ThesisStatus.Defended &&
                            t.IsLocalDevelopment) 
                .CountAsync();
        }


    }

}
