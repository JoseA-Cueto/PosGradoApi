using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_ncategoria_docente", Schema = "sq_personal")]
    public class CategoriaDocente
    {
        [Key]
        public int id_categoria_docente { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }
        public string nombre_categoria_docente { get; set; }
    }
}
