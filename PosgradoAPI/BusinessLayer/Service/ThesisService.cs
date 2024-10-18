using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class ThesisService : IThesisService
    {
        private readonly IThesisRepository _repository;
        private readonly IMapper _mapper;

        public ThesisService(IThesisRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ThesisDto>> GetAllAsync()
        {
            try
            {
                var theses = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<ThesisDto>>(theses);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todas las tesis", ex);
            }
        }

        public async Task<ThesisDto> FindByIdAsync(int id)
        {
            try
            {
                var thesis = await _repository.FindByIdAsync(id);
                return _mapper.Map<ThesisDto>(thesis);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al encontrar la tesis con ID {id}", ex);
            }
        }

        public async Task<int> CountTotalDefendedDoctoralThesesAsync()
        {
            try
            {
                var countProfessors = await _repository.CountDefendedDoctoralThesesByFullTimeProfessorsAsync();
                var countProfessionals = await _repository.CountDefendedDoctoralThesesByProfessionalsAsync();

                return countProfessors + countProfessionals;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis doctorales defendidas", ex);
            }
        }

        public async Task<int> CountDefendedDoctoralThesesInStrategicSectorsAsync()
        {
            try
            {
                return await _repository.CountDefendedDoctoralThesesInStrategicSectorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis doctorales defendidas en sectores estratégicos", ex);
            }
        }

        public async Task<int> CountDefendedDoctoralThesesInLocalDevelopmentAsync()
        {
            try
            {
                return await _repository.CountDefendedDoctoralThesesInLocalDevelopmentAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis doctorales defendidas en desarrollo local", ex);
            }
        }

        public async Task<int> CountDefendedMasterThesesInStrategicSectorsAsync()
        {
            try
            {
                return await _repository.CountDefendedMasterThesesInStrategicSectorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis de maestría defendidas en sectores estratégicos", ex);
            }
        }

        public async Task<int> CountDefendedMasterThesesInLocalDevelopmentAsync()
        {
            try
            {
                return await _repository.CountDefendedMasterThesesInLocalDevelopmentAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis de maestría defendidas en desarrollo local", ex);
            }
        }

        public async Task<int> CountDefendedSpecialtyThesesInStrategicSectorsAsync()
        {
            try
            {
                return await _repository.CountDefendedSpecialtyThesesInStrategicSectorsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis de especialidades defendidas en sectores estratégicos", ex);
            }
        }

        public async Task<int> CountDefendedSpecialtyThesesInLocalDevelopmentAsync()
        {
            try
            {
                return await _repository.CountDefendedSpecialtyThesesInLocalDevelopmentAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las tesis de especialidades defendidas en desarrollo local", ex);
            }
        }
    }
}
