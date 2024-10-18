using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepoBase;

namespace PosgradoAPI.DataLayer.RepositoriesInterfaces
{
    public interface IProfessorRepository : IRepositoryBase<Professor>
    {
        Task<int> CountFullTimeProfessorsAsync();
        Task<(int totalDoctors, int directingDoctors)> CountDoctorsAndDirectingAsync();
        Task<int> CountGraduatedMastersOrSpecialistsAsync();
        Task<int> CountProfessorsWithTrainingAsync();
        Task<int> CountProfessorInCadreAsync();

    }
}
