using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class MarkBlock
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        [MaxLength(255)] public string? Name { get; set; }
        public virtual Guid TrackId { get; set; }
        public virtual Track? Track { get; set; }
        public virtual List<Mark> Marks { get; set; } = [];
        public virtual List<Field> Fields { get; set; } = [];
        public virtual List<Table> Tables { get; set; } = [];
    }
}
