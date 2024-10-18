using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using PosgradoAPI.Enums;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class ProfessorRepository : RepositoryBase<Professor>, IProfessorRepository
    {
        public ProfessorRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<int> CountFullTimeProfessorsAsync()
        {
            return await _context.Professor
                .CountAsync(p => p.Type == ProfessorType.FullTime);
        }

        public async Task<(int totalDoctors, int directingDoctors)> CountDoctorsAndDirectingAsync()
        {
            var totalDoctors = await _context.Professor
                .Where(p => p.ProfessorDegree == Degree.Doctor)
                .CountAsync();

            var directingDoctors = await _context.Professor
                .Where(p => p.ProfessorDegree == Degree.Doctor && p.IsDirectingDoctorate)
                .CountAsync();

            return (totalDoctors, directingDoctors);
        }
        public async Task<int> CountGraduatedMastersOrSpecialistsAsync()
        {
            return await _context.Professor
                .Where(p => p.ProfessorDegree == Degree.Master || p.ProfessorDegree == Degree.Specialist)
                .CountAsync();
        }
        public async Task<int> CountProfessorsWithTrainingAsync()
        {
            return await _context.Professor
                .CountAsync(p => p.ReceivedTraining);
        }
         public async Task<int> CountProfessorInCadreAsync()
        {
            return await _context.Professor.CountAsync(p => p.AffiliationWithTheParty == AffiliationWithTheParty.Cadre);
        }


    }

}
