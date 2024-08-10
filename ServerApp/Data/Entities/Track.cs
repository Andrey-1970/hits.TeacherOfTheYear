using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Track
    {
        public Guid Id { get; set; }
        [MaxLength(255)] public string? Name { get; set; }
        public virtual List<MarkBlock> MarkBlocks { get; set; } = [];
        public virtual List<EditBlock> EditBlocks { get; set; } = [];
        public virtual List<ApplicationForm> Applications { get; set; } = [];
    }
}
