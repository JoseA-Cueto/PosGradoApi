using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using PosgradoAPI.Enums;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class GraduateProgramRepository : RepositoryBase<GraduateProgram>, IGraduateProgramRepository
    {
        public GraduateProgramRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<int> CountProgramsInStrategicSectorsAsync()
        {
            return await _context.GraduateProgram
                .Where(gp => gp.IsStrategicSector)
                .CountAsync();
        }

        public async Task<int> CountProgramsInLocalDevelopmentAsync()
        {
            return await _context.GraduateProgram
                .Where(gp => gp.IsLocalDevelopment)
                .CountAsync();
        }
        public async Task<(int TotalPrograms, int DistancePrograms)> CountProgramsAsync()
        {
            var totalPrograms = await _context.GraduateProgram.CountAsync();
            var distancePrograms = await _context.GraduateProgram.CountAsync(g => g.Modality == Modality.Distance);

            return (totalPrograms, distancePrograms);
        }
        public async Task<(int TotalPrograms, int SuperiorAccreditedPrograms)> CountProgramsWithSuperiorAccreditationAsync()
        {
            var totalPrograms = await _context.GraduateProgram.CountAsync();
            var superiorAccreditedPrograms = await _context.GraduateProgram
                .CountAsync(g => g.AccreditationCategory == AccreditationCategory.Superior);

            return (totalPrograms, superiorAccreditedPrograms);
        }


    }

}
