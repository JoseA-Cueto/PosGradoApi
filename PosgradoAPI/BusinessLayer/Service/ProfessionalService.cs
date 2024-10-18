using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using PosgradoAPI.Enums;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class ProfessionalService : IProfessionalService
    {
        private readonly IProfessionalRepository _repository;
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessionalService(IProfessionalRepository repository, IMapper mapper, IProfessorRepository professorRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _professorRepository = professorRepository;
        }

        public async Task<IEnumerable<ProfessionalDto>> GetAllAsync()
        {
            try
            {
                var professionals = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<ProfessionalDto>>(professionals);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los profesionales", ex);
            }
        }

        public async Task<ProfessionalDto> FindByIdAsync(int id)
        {
            try
            {
                var professional = await _repository.FindByIdAsync(id);
                return _mapper.Map<ProfessionalDto>(professional);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al encontrar el profesional con ID {id}", ex);
            }
        }

        public async Task<int> CountByProgramTypeAndStatusAsync(ProgramType programType, ProfessionalType type)
        {
            try
            {
                return await _repository.CountByProgramTypeAndStatusAsync(programType, type);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales por tipo de programa y estado", ex);
            }
        }

        public async Task<int> CountProfessionalsInDoctorateProgramsAsync()
        {
            try
            {
                return await _repository.CountProfessionalsInDoctorateProgramsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales en programas de doctorado", ex);
            }
        }

        public async Task<int> CountDoctorateProfessionalsInStrategicSectorsAsync()
        {
            try
            {
                return await _repository.CountDoctorateProfessionalsInStrategicSectorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales de doctorado en sectores estratégicos", ex);
            }
        }

        public async Task<int> CountDoctorateProfessionalsInLocalDevelopmentAsync()
        {
            try
            {
                return await _repository.CountDoctorateProfessionalsInLocalDevelopmentAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales de doctorado en desarrollo local", ex);
            }
        }

        public async Task<int> CountProfessionalsInStrategicSectorsAsync()
        {
            try
            {
                return await _repository.CountProfessionalsInStrategicSectorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales en sectores estratégicos", ex);
            }
        }
        public async Task<int> CountProfessionalsAndProfessorsWithTrainingAsync()
        {
            try
            {
                
                var professionalCount = await _repository.CountProfessionalsWithTrainingAsync();

              
                var professorCount = await _professorRepository.CountProfessorsWithTrainingAsync();

            
                return professionalCount + professorCount;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales y profesores con capacitación", ex);
            }
        }


        public async Task<int> CountProfessionalsAndProfessorsWithCardreAsync()
        {
            try
            {

                var professionalCount = await _repository.CountProfessionalInCadreAsync();


                var professorCount = await _professorRepository.CountProfessorInCadreAsync();


                return professionalCount + professorCount;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar profesionales y profesores que soncuadros", ex);
            }
        }


    }
}

