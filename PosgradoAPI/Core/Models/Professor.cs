using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("Professor")]
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProfessorType Type { get; set; }
        public ProfessionalType TypeProfesional { get; set; }
        public AffiliationWithTheParty AffiliationWithTheParty { get; set; }
        public Degree ProfessorDegree { get; set; }
        public bool IsDirectingDoctorate { get; set; }
        public bool ReceivedTraining { get; set; }
        public int? GraduateProgramId { get; set; }
        [ForeignKey("GraduateProgramId")]
        public virtual GraduateProgram GraduateProgram { get; set; }
        public virtual ICollection<Thesis> Thesis { get; set; }
    }
}
