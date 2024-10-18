using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;

namespace PosgradoAPI.BusinessLayer.ServiceInterface
{
    public interface IProfessorService
    {
        Task<IEnumerable<ProfessorDto>> GetAllAsync();
        Task<ProfessorDto> FindByIdAsync(int id);
        Task<int> CountFullTimeProfessorsAsync();
        Task<double> CalculatePercentageOfDirectingDoctorsAsync();
        Task<int> CountGraduatedMastersOrSpecialistsAsync();
    }
}
