using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("GraduateProgram")]
    public class GraduateProgram
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProgramType Type { get; set; }
        public bool IsStrategicSector { get; set; }
        public bool IsLocalDevelopment { get; set; }
        public Modality Modality { get; set; }
        public AccreditationCategory AccreditationCategory { get; set; }
        public virtual ICollection<Professional> Professional { get; set; }
        public virtual ICollection<Professor> Professor { get; set; }
    }
}
