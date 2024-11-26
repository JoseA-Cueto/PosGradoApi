using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_dparticipante", Schema = "sq_personal")]
    public class Participante
    {
        public string titulo { get; set; }

        [MaxLength(10)]
        public string tomo_titulo { get; set; }

        [MaxLength(100)]
        public string foto { get; set; }

        public int? id_categoria_docente { get; set; }
        [ForeignKey("id_categoria_docente")]
        public virtual CategoriaDocente categoriaDocente { get; set; }

        [MaxLength(20)]
        public string telefono { get; set; }

        [MaxLength(50)]
        public string correo_electronico { get; set; }

        [MaxLength(100)]
        public string centro_trabajo { get; set; }

        [MaxLength(15)]
        public string folio_titulo { get; set; }

        [MaxLength(20)]
        public string telefono_centro_trabajo { get; set; }

        [MaxLength(200)]
        public string direccion_centro_trabajo { get; set; }

        [MaxLength(30)]
        public string tiempo_en_cargo { get; set; }

        public int? id_categoria_investigativa { get; set; }
        [ForeignKey("id_categoria_investigativa")]
        public virtual CategoriaInvestigativa categoriaInvestigativa { get; set; }
        public int? id_grado_cientifico { get; set; }
        [ForeignKey("id_grado_cientifico")]
        public virtual GradoCientifico gradoCientifico { get; set; }
        public bool activo { get; set; }
        public bool cuadro { get; set; }

        public int? id_universidad { get; set; }

        [MaxLength(32)]
        [Key]
        public string id_persona { get; set; }
        [ForeignKey("id_persona")]
        public virtual Persona persona { get; set; }

        public int? ano_ingreso_educ_superior { get; set; }

        [MaxLength(30)]
        public string id_pais_estudios { get; set; }

        public string fecha_graduado { get; set; } 

        public string numero_titulo { get; set; }

        public int? id_carrera { get; set; }
        public int? id_cuenta_propia { get; set; }
        [ForeignKey("id_cuenta_propia")]
        public virtual CuentaPropia cuentaPropia { get; set; }

        public string numero_licencia { get; set; }

        public bool cuenta_propia { get; set; }
    }
}
