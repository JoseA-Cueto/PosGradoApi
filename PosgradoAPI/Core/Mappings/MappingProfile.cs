using AutoMapper;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
namespace PosgradoAPI.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Solicitud, SolicitudDTO>().ReverseMap();
            CreateMap<Participante, ParticipanteDTO>().ReverseMap();
            CreateMap<TomoFolio, TomoFolioDTO>().ReverseMap();
            CreateMap<Actividad, ActividadDTO>().ReverseMap();

        }
    }
}
