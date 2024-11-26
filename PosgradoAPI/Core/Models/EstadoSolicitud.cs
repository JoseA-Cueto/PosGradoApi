using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_nestado_solicitud", Schema = "sq_formacion_postgraduada")]
    public class EstadoSolicitud
    {
        [Key]
        public int id_estado_solicitud { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }
        public string nombre_estado_solicitud { get; set; }
    }
}
