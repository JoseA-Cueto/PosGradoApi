using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace PosgradoAPI.Core.DTOs
{
    public class ProfessorDto
    {
    
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProfessorType Type { get; set; }
        public AffiliationWithTheParty AffiliationWithTheParty { get; set; }
        public Degree ProfessorDegree { get; set; }
        public int? GraduateProgramId { get; set; }
        public bool ReceivedTraining { get; set; }
    }
}

