using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Table
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        [MaxLength(255)] 
        public string? Name { get; set; }

        public bool IsPrefilled { get; set; } = false;
        
        public bool IsDisplayedOnVotingPage { get; set; } = false;

        public virtual Guid EditBlockId { get; set; }
        public virtual EditBlock? EditBlock { get; set; }
        public virtual List<MarkBlock> MarkBlocks { get; set; } = [];
        public virtual List<Mark> Marks { get; set; } = [];
        public virtual List<Row> Rows { get; set; } = [];
        public virtual List<Column> Columns { get; set; } = [];
    }
}
