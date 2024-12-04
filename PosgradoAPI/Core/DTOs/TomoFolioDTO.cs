using PosgradoAPI.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.DTOs
{
    public class TomoFolioDTO
    {
        public string id_persona { get; set; }
        public int id_convocatoria { get; set; }
        public string tomo { get; set; }
        public string folio { get; set; }
        public string numero { get; set; }
        public bool profesor { get; set; }
        public string id_persona_secretaria { get; set; }
        public string id_persona_profesor { get; set; }
        public string id_persona_jefe { get; set; }
    }
}