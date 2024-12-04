using Microsoft.EntityFrameworkCore;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.RepoBase;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace PosgradoAPI.DataLayer.Repositories
{
    public class SolicitudRepository : RepositoryBase<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(AppDbContext context) : base(context)
        {
           
        }
        public async Task<int> GetDoctoralProgramFacultyCount()
        {

            var categoriasDocente = new List<int> { 3, 4, 6, 16 };

          
            const int idConvocatoria = 3033;

            
            var cantidad = await _context.Set<Solicitud>()
                .Where(s =>
                    s.id_convocatoria == idConvocatoria && 
                    s.estadoSolicitud.activo == true && 
                    categoriasDocente.Contains(s.participante.id_categoria_docente.Value) 
                )
                .Select(s => s.id_persona) 
                .Distinct() 
                .CountAsync();

            return cantidad;
        }

        public async Task<int> GetFilteredSolicitudesCountAsync()
        {
           
            const int idActividad = 3033;

           
            var gradosCientificos = new List<int> { 12, 13, 24, 26 };

           
            var cantidad = await _context.Set<Solicitud>()
                .Where(s =>
                   
                    s.id_convocatoria == idActividad &&
                   
                    gradosCientificos.Contains(s.participante.id_grado_cientifico.Value)
                )
                .CountAsync(); 

            return cantidad;
        }

    }
}
