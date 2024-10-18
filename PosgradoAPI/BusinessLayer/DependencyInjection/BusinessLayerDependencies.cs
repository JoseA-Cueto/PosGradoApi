using PosgradoAPI.BusinessLayer.Service;
using PosgradoAPI.BusinessLayer.ServiceInterface;

namespace PosgradoAPI.BusinessLayer.DependencyInjection
{
    public static class BusinessLayerDependencies
    {
        public static void AddBusinessLayerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGraduateProgramService, GraduateProgramService>();
            services.AddScoped<IThesisService, ThesisService>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IProfessionalService, ProfessionalService>();

        }
    }
}
