using PosgradoAPI.Core.Models;
using PosgradoAPI.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PosgradoAPI.Core.DTOs
{
    public class ThesisDto
    {
      
        public int Id { get; set; }
        public string? Title { get; set; }
        public ThesisType Type { get; set; }
        public int ProfessionalId { get; set; }
        public bool IsStrategicSector { get; set; }
        public bool IsLocalDevelopment { get; set; }
        public ThesisStatus Status { get; set; }
    }
}
