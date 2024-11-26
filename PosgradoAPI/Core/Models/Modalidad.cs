using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_nmodalidad", Schema = "sq_formacion_postgraduada")]
    public class Modalidad
    {
        [Key]
        public int id_modalidad { get; set; }
        public string nombre_modalidad { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }

    }
}
