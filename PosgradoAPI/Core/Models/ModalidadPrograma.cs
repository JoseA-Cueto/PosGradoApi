using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_nmodalidad_programa", Schema = "sq_formacion_postgraduada")]
    public class ModalidadPrograma
    {
        [Key]
        public int id_modalidad_programa { get; set; }
        public string nombre_modalidad_programa { get; set; }
        public string? descripcion { get; set; }
        public DateTime fecha_registro { get; set; } = DateTime.Now;
        public bool activo { get; set; }
    }
}
