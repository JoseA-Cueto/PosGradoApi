using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_dprograma", Schema = "sq_formacion_postgraduada")]
    public class Programa
    {
       
        [Key]
        public int id_programa { get; set; }
        public string url_programa { get; set; }
        public string nombre_programa { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
        [MaxLength(150)]
        public string nombre_url_programa { get; set; }
        [MaxLength(100)]
        public string nombre_autor { get; set; }
        public int? id_forma_organizativa { get; set; }
        public int? id_linea_programa { get; set; }
        public int? version { get; set; }
        [MaxLength(32)]
        public string id_persona_autor { get; set; }
        [ForeignKey("id_persona_autor")]
        public virtual Persona persona { get; set; }
        public string fundamentacion { get; set; }
        public string objetivo_general { get; set; }
        public string descripcion_temas { get; set; }
        public string indicaciones_metod { get; set; }
        public string bibliografia { get; set; }
        public string sistema_evaluacion { get; set; }
        public int? creditos { get; set; }
        public int? total_horas { get; set; }
        public DateTime fecha_registro { get; set; } = DateTime.Now;
        public int? id_modalidad_programa { get; set; }
        [ForeignKey("id_modalidad_programa")]
        public virtual ModalidadPrograma modalidadPrograma { get; set; }
    }
}
