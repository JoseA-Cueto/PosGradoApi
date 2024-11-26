using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_nperiodicidad", Schema = "sq_formacion_postgraduada")]
    public class Periodicidad
    {
        [Key]
        public int id_periodicidad { get; set; }
        public string nombre_periodicidad { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }

    }
}
