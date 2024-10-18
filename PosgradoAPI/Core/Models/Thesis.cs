using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("Thesis")]
    public class Thesis
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public ThesisType Type { get; set; }
        public int ProfessionalId { get; set; }
        [ForeignKey("ProfessionalId")]
        public virtual Professional Professional { get; set; }
        public int ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }
        public bool IsStrategicSector { get; set; }
        public bool IsLocalDevelopment { get; set; }
        public ThesisStatus Status { get; set; }
    }
}
