using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_ncategoria_investigativa", Schema = "sq_personal")]
    public class CategoriaInvestigativa
    {
        [Key]
        public int id_categoria_investigativa { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }
        public string nombre_categoria_investigativa { get; set; }
    }
}
