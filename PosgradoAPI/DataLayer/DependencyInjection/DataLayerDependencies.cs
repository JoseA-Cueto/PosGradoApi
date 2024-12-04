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
       
            services.AddScoped<ISolicitudRepository, SolicitudRepository>();
            services.AddScoped<IParticipanteRepository, ParticipanteRepository>();
            services.AddScoped<ITomoFolioRepository, TomoFolioRepository>();
            services.AddScoped<IActividadRepository, ActividadRepository>();


        }
    }
}
