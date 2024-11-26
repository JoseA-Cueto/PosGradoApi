using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_nforma_organizativa", Schema = "sq_formacion_postgraduada")]
    public class FormaOrganizativa
    {
        [Key]
        public int id_forma_organizativa { get; set; }
        public string nombre_forma_organizativa { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }

    }
}
