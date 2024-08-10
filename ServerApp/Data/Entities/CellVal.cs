using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class CellVal
    {
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string? Value { get; set; }
        public virtual Guid ApplicationId { get; set; }
        public virtual ApplicationForm? Application { get; set; }
        public virtual Guid RowId { get; set; }
        public virtual Row? Row { get; set; }
        public virtual Guid ColumnId { get; set; }
        public virtual Column? Column { get; set; }
    }
}
