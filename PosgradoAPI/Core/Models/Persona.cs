using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_dpersona", Schema = "sq_personal")]
    public class Persona
    {
        [Key]
        public string id_persona { get; set; }
        public bool jefe_autorizado { get; set; }
        public int? id_cargo { get; set; }
        public string? id_area { get; set; }

    }
}
