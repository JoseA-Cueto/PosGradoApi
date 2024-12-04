using PosgradoAPI.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.DTOs
{
    public class ActividadDTO
    {
        public int id_actividad { get; set; }
        public DateTime? fecha_inicio { get; set; }
        public int? horas_totales { get; set; }
        public string nombre_actividad { get; set; }
        public int? id_periodicidad { get; set; }
       
        public int? id_modalidad { get; set; }
       
        public int? id_universidad_colaboradora { get; set; }
        public int? id_universidad_rectora { get; set; }
        public int? matricula_total { get; set; }
        public DateTime? fecha_fin { get; set; }
        public int? id_forma_organizativa { get; set; }
        
        public int? id_programa { get; set; }
        public int? total_creditos { get; set; }
        public bool activo { get; set; }
        public string id_area { get; set; }
        public int? id_pais { get; set; }
        public string area_influencia { get; set; }
        public string secretaria_creadora { get; set; }
        public string siglas { get; set; }
        public DateTime fecha_registro { get; set; } = DateTime.Now;
    }
}
