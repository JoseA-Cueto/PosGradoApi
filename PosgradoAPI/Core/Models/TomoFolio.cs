using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_rtomo_folio_num", Schema = "sq_tesis_titulos")]
    public class TomoFolio
    {
        
        public string id_persona { get; set; }
        [ForeignKey("id_persona")]
        public virtual Persona persona { get; set; }
        public int id_actividad { get; set; }
        [ForeignKey("id_actividad")]
        public virtual Actividad Actividad { get; set; }
        public string tomo { get; set; }
        public string folio { get; set; }
        public string numero { get; set; }
        public bool profesor { get; set; }
        public string id_persona_secretaria { get; set; }
        [ForeignKey("id_persona_secretaria")]
        public virtual Persona personasSecretaria { get; set; }
        public string id_persona_profesor { get; set; }
        [ForeignKey("id_persona_profesor")]
        public virtual Persona personaProfesor { get; set; }
        public string id_persona_jefe { get; set; }
        [ForeignKey("id_persona_jefe")]
        public virtual Persona personasJefe { get; set; }
    }
}
