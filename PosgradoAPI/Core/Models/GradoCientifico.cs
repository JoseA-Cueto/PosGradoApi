using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_ngrado_cientifico", Schema = "sq_personal")]
    public class GradoCientifico
    {
        [Key]
        public int id_grado_cientifico { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }
        public string nombre_grado_cientifico { get; set; }
        public string sigla { get; set; }
    }
}
