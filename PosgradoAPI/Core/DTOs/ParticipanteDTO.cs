using PosgradoAPI.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PosgradoAPI.Core.DTOs
{
    public class ParticipanteDTO
    {
        public string titulo { get; set; }

      
        public string tomo_titulo { get; set; }

   
        public string foto { get; set; }

        public int? id_categoria_docente { get; set; }  
        public string telefono { get; set; }

      
        public string correo_electronico { get; set; }

        public string centro_trabajo { get; set; }

     
        public string folio_titulo { get; set; }

     
        public string telefono_centro_trabajo { get; set; }

      
        public string direccion_centro_trabajo { get; set; }


        public string tiempo_en_cargo { get; set; }

        public int? id_categoria_investigativa { get; set; }
        public int? id_grado_cientifico { get; set; }
        public bool activo { get; set; }
        public bool cuadro { get; set; }
        public int? id_universidad { get; set; }
        public string id_persona { get; set; }
        public int? ano_ingreso_educ_superior { get; set; }
        public string id_pais_estudios { get; set; }
        public string fecha_graduado { get; set; }
        public string numero_titulo { get; set; }
        public int? id_carrera { get; set; }
        public int? id_cuenta_propia { get; set; }
        public string numero_licencia { get; set; }

        public bool cuenta_propia { get; set; }
    }
}
