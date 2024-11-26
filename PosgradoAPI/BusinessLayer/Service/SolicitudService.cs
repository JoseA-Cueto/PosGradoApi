﻿using AutoMapper;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PosgradoAPI.BusinessLayer.Service
{
    public class SolicitudService : ISolicitudService
    {
        private readonly ISolicitudRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

       
        public SolicitudService(ISolicitudRepository repository, IMapper mapper, ILogger<SolicitudService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }


        public async Task<int> CountAsync(int idEstadoSolicitud)
        {
            try
            {
              
                return await _repository.CountAsync(s => s.id_estado_solicitud == idEstadoSolicitud);
            }
            catch (Exception ex)
            {
             
                _logger.LogError($"Error al contar las solicitudes con id_estado_solicitud = {idEstadoSolicitud}: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al contar las solicitudes.");
            }
        }



        public async Task<SolicitudDTO> FindByIdAsync(int id)
        {
            try
            {
                
                var solicitud = await _repository.FindByIdAsync(id);
                if (solicitud == null)
                {
                    throw new KeyNotFoundException($"No se encontró una solicitud con el ID {id}.");
                }

               
                return _mapper.Map<SolicitudDTO>(solicitud);
            }
            catch (Exception ex)
            {
               
                _logger.LogError($"Error al encontrar la solicitud con ID {id}: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al encontrar la solicitud.");
            }
        }

      
        public async Task<IEnumerable<SolicitudDTO>> GetAllAsync()
        {
            try
            {
         
                var solicitudes = await _repository.GetAllAsync();

               
                return _mapper.Map<IEnumerable<SolicitudDTO>>(solicitudes);
            }
            catch (Exception ex)
            {
          
                _logger.LogError($"Error al obtener todas las solicitudes: {ex.Message}", ex);
                throw new ApplicationException("Ocurrió un error al obtener las solicitudes.");
            }
        }
    }
}