using AutoMapper;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
namespace PosgradoAPI.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GraduateProgram, GraduateProgramDto>().ReverseMap();
            CreateMap<Thesis, ThesisDto>().ReverseMap();
            CreateMap<Professor, ProfessorDto>().ReverseMap();
            CreateMap<Professional, ProfessionalDto>().ReverseMap();
        }
    }
}
