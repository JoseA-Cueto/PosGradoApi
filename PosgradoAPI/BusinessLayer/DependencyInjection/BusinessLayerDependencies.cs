using Microsoft.Extensions.Logging;
using PosgradoAPI.BusinessLayer.Service;
using PosgradoAPI.BusinessLayer.ServiceInterface;

namespace PosgradoAPI.BusinessLayer.DependencyInjection
{
    public static class BusinessLayerDependencies
    {
        public static void AddBusinessLayerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ISolicitudService, SolicitudService>();
            services.AddScoped<IParticipanteService, ParticipanteService>();
            services.AddScoped<ITomoFolioService, TomoFolioService>();
            services.AddScoped<IActividadService, ActividadService>();


        }
    }
}
