using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace PosgradoAPI.Core.DTOs
{
    public class GraduateProgramDto
    {
      
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProgramType Type { get; set; }
        public bool IsStrategicSector { get; set; }
        public bool IsLocalDevelopment { get; set; }
        public Modality Modality { get; set; }
        public AccreditationCategory AccreditationCategory { get; set; }
    }
}
