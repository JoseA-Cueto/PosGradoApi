using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_dconvocatoria", Schema = "sq_formacion_postgraduada")]
    public class Convocatoria
    {
        [Key]
        public int id_convocatoria { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime fecha_inicio { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }
        public int id_actividad { get; set; }
        [ForeignKey("id_actividad")]
        public virtual Actividad actividad { get; set; }
        public bool abierta { get; set; }
        public int id_estado_convocatoria { get; set; }
        [ForeignKey("id_estado_convocatoria")]
        public virtual EstadoConvocatoria estadoConvocatoria { get; set; }



    }
}