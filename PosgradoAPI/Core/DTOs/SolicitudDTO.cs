using PosgradoAPI.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.DTOs
{
    public class SolicitudDTO
    {
       
        public int id_solicitud { get; set; }
        public string id_persona { get; set; }
        public int? id_convocatoria { get; set; }
        public int? id_estado_solicitud { get; set; }
  
    }
}
