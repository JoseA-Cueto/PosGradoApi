using PosgradoAPI.Core.Models;
using PosgradoAPI.Enums;

namespace PosgradoAPI.Core.DTOs
{
    public class ProfessionalDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProfessionalType Type { get; set; }
        public AffiliationWithTheParty AffiliationWithTheParty { get; set; }
        public bool IsStrategicSector { get; set; }
        public bool IsLocalDevelopment { get; set; }
        public bool ReceivedTraining { get; set; }
        public int? GraduateProgramId { get; set; }

    }
}
