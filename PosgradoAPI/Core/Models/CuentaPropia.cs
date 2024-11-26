using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("tb_ncuenta_propia", Schema = "sq_personal")]
    public class CuentaPropia
    {
        [Key]
        public int id_cuenta_propia { get; set; }
        public string? descripcion { get; set; }
        public bool activo { get; set; }
        public string nombre_cuenta_propia { get; set; }
        public DateTime fecha_registro { get; set; } = DateTime.Now;
    }
}
