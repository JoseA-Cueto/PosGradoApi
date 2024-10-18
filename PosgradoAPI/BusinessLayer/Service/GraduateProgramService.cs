using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class GraduateProgramService : IGraduateProgramService
    {
        private readonly IGraduateProgramRepository _repository;
        private readonly IMapper _mapper;

        public GraduateProgramService(IGraduateProgramRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GraduateProgramDto>> GetAllAsync()
        {
            try
            {
                var graduatePrograms = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<GraduateProgramDto>>(graduatePrograms);
            }
            catch (Exception ex)
            {
               
                throw new Exception("Error al obtener todos los programas de posgrado", ex);
            }
        }

        public async Task<GraduateProgramDto> FindByIdAsync(int id)
        {
            try
            {
                var graduateProgram = await _repository.FindByIdAsync(id);
                return _mapper.Map<GraduateProgramDto>(graduateProgram);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al encontrar el programa de posgrado con ID {id}", ex);
            }
        }

        public async Task<int> CountStrategicSectorProgramsAsync()
        {
            try
            {
                return await _repository.CountProgramsInStrategicSectorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar los programas en sectores estratégicos", ex);
            }
        }

        public async Task<int> CountLocalDevelopmentProgramsAsync()
        {
            try
            {
                return await _repository.CountProgramsInLocalDevelopmentAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar los programas en desarrollo local", ex);
            }
        }
        public async Task<double> CalculatePercentageOfDistanceProgramsAsync()
        {
            try
            {
                var (totalPrograms, distancePrograms) = await _repository.CountProgramsAsync();
                if (totalPrograms == 0) return 0;

                return (double)distancePrograms / totalPrograms * 100;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular el porcentaje de programas académicos a distancia", ex);
            }
        }
        public async Task<double> CalculatePercentageOfSuperiorAccreditedProgramsAsync()
        {
            try
            {
                var (totalPrograms, superiorAccreditedPrograms) = await _repository.CountProgramsWithSuperiorAccreditationAsync();
                if (totalPrograms == 0) return 0;

                return (double)superiorAccreditedPrograms / totalPrograms * 100;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular el porcentaje de programas con categoría superior de acreditación", ex);
            }
        }


    }
}

