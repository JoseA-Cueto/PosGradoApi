using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_nestado_convocatoria", Schema = "sq_formacion_postgraduada")]
    public class EstadoConvocatoria
    {
        [Key]
        public int id_estado_convocatoria { get; set; }
        public string nombre_estado_convocatoria { get; set; }
        public string? descripcion { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool activo { get; set; }
    }
}
