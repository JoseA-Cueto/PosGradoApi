using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _repository;
        private readonly IMapper _mapper;

        public ProfessorService(IProfessorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProfessorDto>> GetAllAsync()
        {
            try
            {
                var professors = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<ProfessorDto>>(professors);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los profesores", ex);
            }
        }

        public async Task<ProfessorDto> FindByIdAsync(int id)
        {
            try
            {
                var professor = await _repository.FindByIdAsync(id);
                return _mapper.Map<ProfessorDto>(professor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al encontrar el profesor con ID {id}", ex);
            }
        }

        public async Task<int> CountFullTimeProfessorsAsync()
        {
            try
            {
                return await _repository.CountFullTimeProfessorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar los profesores a tiempo completo", ex);
            }
        }

        public async Task<double> CalculatePercentageOfDirectingDoctorsAsync()
        {
            try
            {
                var (totalDoctors, directingDoctors) = await _repository.CountDoctorsAndDirectingAsync();

                if (totalDoctors == 0) return 0;

                return (double)directingDoctors / totalDoctors * 100;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular el porcentaje de doctores dirigiendo", ex);
            }
        }
        public async Task<int> CountGraduatedMastersOrSpecialistsAsync()
        {
            try
            {
                return await _repository.CountGraduatedMastersOrSpecialistsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar los miembros del claustro graduados de máster o especialista", ex);
            }
        }

    }
}

