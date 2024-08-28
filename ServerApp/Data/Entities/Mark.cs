using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Mark
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        [MaxLength(255)] 
        public string? Name { get; set; }

        public bool IsAuto { get; set; } = true;
        public int MaxValue { get; set; }
        public virtual Guid? FieldId { get; set; }
        public virtual Field? Field { get; set; }
        public virtual Guid? TableId { get; set; }
        public virtual Table? Table { get; set; }
        public virtual List<MarkBlock> MarkBlocks { get; set; } = [];
        public virtual List<MarkVal> MarkVals { get; set; } = [];
    }
}
