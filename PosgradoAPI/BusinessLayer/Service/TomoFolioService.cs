using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using System.Linq;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class TomoFolioService : ITomoFolioService
    {
        private readonly ITomoFolioRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public TomoFolioService(ITomoFolioRepository repository, IMapper mapper, ILogger<TomoFolioService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }


        public async Task<int> GetFilteredTomoFolioCountAsync()
        {
            try
            {
                
                var count = await _repository.GetFilteredTomoFolioCountAsync();

                return count;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener el conteo de TomoFolio filtrado: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al obtener el conteo de TomoFolio filtrado.");
            }
        }


        public async Task<TomoFolioDTO> FindByIdAsync(int id)
        {
            try
            {

                var solicitud = await _repository.FindByIdAsync(id);
                if (solicitud == null)
                {
                    throw new KeyNotFoundException($"No se encontró una solicitud con el ID {id}.");
                }


                return _mapper.Map<TomoFolioDTO>(solicitud);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Error al encontrar la solicitud con ID {id}: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al encontrar la solicitud.");
            }
        }


        public async Task<IEnumerable<TomoFolioDTO>> GetAllAsync()
        {
            try
            {

                var solicitudes = await _repository.GetAllAsync();


                return _mapper.Map<IEnumerable<TomoFolioDTO>>(solicitudes);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Error al obtener todas las solicitudes: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al obtener las solicitudes.");
            }
        }
    }
}