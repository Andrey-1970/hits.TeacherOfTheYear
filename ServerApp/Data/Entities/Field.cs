using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Field
    {
        public Guid Id { get; set; }
        [MaxLength(255)] public string? Name { get; set; } //todo: может быть не уникальным?
        public virtual Guid MarkBlockId { get; set; }
        public virtual MarkBlock? MarkBlock { get; set; }
        public virtual Guid EditBlockId { get; set; }
        public virtual EditBlock? EditBlock { get; set; }
        public virtual List<FieldVal> FieldVals { get; set; } = [];
    }
}
