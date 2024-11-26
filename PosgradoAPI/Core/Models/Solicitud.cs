using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_dsolicitud", Schema = "sq_formacion_postgraduada")]
    public class Solicitud
    {
        [Key]
        public int id_solicitud { get; set; }
        public string id_persona { get; set; }
        [ForeignKey("id_persona")]
        public virtual Participante participante { get; set; }
        public int? id_convocatoria { get; set; }
        [ForeignKey("id_convocatoria")]
        public virtual Convocatoria convocatoria { get; set; }
        public int? id_estado_solicitud { get; set; }
        [ForeignKey("id_estado_solicitud")]
        public virtual EstadoSolicitud estadoSolicitud { get; set; }


    }
}