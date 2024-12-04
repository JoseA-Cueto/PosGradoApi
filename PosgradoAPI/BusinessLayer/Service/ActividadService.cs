using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class ActividadService : IActividadService
    {
        private readonly IActividadRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ActividadService(IActividadRepository repository, IMapper mapper, ILogger<ActividadDTO> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> CountAsync()
        {
            try
            {
                return await _repository.CountAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al contar las actividades: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al contar las actividades.");
            }
        }

        public async Task<ActividadDTO> FindByIdAsync(int id)
        {
            try
            {
                var actividad = await _repository.FindByIdAsync(id); 
                if (actividad == null)
                {
                    return null; 
                }

                return _mapper.Map<ActividadDTO>(actividad);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al buscar la actividad con id {id}: {ex.Message}", ex);
                throw new ApplicationException($"Ocurrió un error al buscar la actividad con id {id}.");
            }
        }

        public async Task<IEnumerable<ActividadDTO>> GetAllAsync()
        {
            try
            {
                var actividades = await _repository.GetAllAsync(); 
                return _mapper.Map<IEnumerable<ActividadDTO>>(actividades); 
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener las actividades: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al obtener las actividades.");
            }
        }
        public async Task<int> ObtenerMatriculaTotalActivasAsync()
        {
            try
            {
                
                var actividadesActivas = await _repository.GetAllAsync(); 
                
                int totalMatricula = actividadesActivas
                    .Where(a => a.activo == true)
                    .Sum(a => a.matricula_total ?? 0); 

                return totalMatricula;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener la matrícula total de actividades activas: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al obtener la matrícula total de actividades activas.");
            }
        }

    }
}
