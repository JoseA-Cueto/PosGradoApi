using PosgradoAPI.BusinessLayer.Service;
using PosgradoAPI.BusinessLayer.ServiceInterface;
using PosgradoAPI.DataLayer.Repositories;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.DataLayer.DependencyInjection
{
    public static class DataLayerDependencies
    {
        public static void AddDataLayerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGraduateProgramRepository, GraduateProgramRepository>();
            services.AddScoped<IThesisRepository, ThesisRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
            services.AddScoped<IProfessionalRepository, ProfessionalRepository>();

        }
    }
}
