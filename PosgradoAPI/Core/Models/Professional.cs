using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosgradoAPI.Core.Models
{
    [Table("Professional")]
    public class Professional
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProfessionalType Type { get; set; }
        public AffiliationWithTheParty AffiliationWithTheParty { get; set; }
        public bool IsStrategicSector { get; set; }
        public bool IsLocalDevelopment { get; set; }
        public bool ReceivedTraining { get; set; }
        public int? GraduateProgramId { get; set; }
        [ForeignKey("GraduateProgramId")]
        public virtual GraduateProgram GraduateProgram { get; set; }
        public virtual ICollection<Thesis> Thesis { get; set; }
    }
}
