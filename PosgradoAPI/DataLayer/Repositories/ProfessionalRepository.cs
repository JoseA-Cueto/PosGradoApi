using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using PosgradoAPI.Enums;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class ProfessionalRepository : RepositoryBase<Professional>, IProfessionalRepository
    {
        public ProfessionalRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<int> CountByProgramTypeAndStatusAsync(ProgramType programType, ProfessionalType type)
        {
            return await _context.Professional
                .Include(p => p.GraduateProgram)
                .CountAsync(p => p.GraduateProgram != null &&
                                 p.GraduateProgram.Type == programType &&
                                 p.Type == type);
        }

        public async Task<int> CountProfessionalsInDoctorateProgramsAsync()
        {
            return await _context.Professional
                .Include(p => p.GraduateProgram)
                .CountAsync(p => p.GraduateProgram != null && p.GraduateProgram.Type == ProgramType.Doctorate);
        }

        public async Task<int> CountDoctorateProfessionalsInStrategicSectorsAsync()
        {
            return await _context.Professional
                .Include(p => p.GraduateProgram)
                .Where(p => p.GraduateProgram != null &&
                            p.GraduateProgram.Type == ProgramType.Doctorate &&
                            p.IsStrategicSector) 
                .CountAsync();
        }

        public async Task<int> CountDoctorateProfessionalsInLocalDevelopmentAsync()
        {
            return await _context.Professional
                .Include(p => p.GraduateProgram)
                .Where(p => p.GraduateProgram != null &&
                            p.GraduateProgram.Type == ProgramType.Doctorate &&
                            p.IsLocalDevelopment)
                .CountAsync();
        }

        public async Task<int> CountProfessionalsInStrategicSectorsAsync()
        {
            return await _context.Professional
                .Include(p => p.GraduateProgram)
                .Where(p => p.GraduateProgram != null &&
                            p.GraduateProgram.IsStrategicSector)
                .CountAsync();
        }
        public async Task<int> CountProfessionalsWithTrainingAsync()
        {
            return await _context.Professional
                .CountAsync(p => p.ReceivedTraining);
        }
        public async Task<int> CountProfessionalInCadreAsync()
        {
            return await _context.Professional.CountAsync(p => p.AffiliationWithTheParty == AffiliationWithTheParty.Cadre);
        }

    }

}
