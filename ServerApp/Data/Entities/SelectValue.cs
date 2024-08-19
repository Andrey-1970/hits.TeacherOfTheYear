using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities;

public class SelectValue
{
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string? Value { get; set; }
    public virtual Guid? FieldId { get; set; }
    public virtual Field? Field { get; set; }
    public virtual Guid? ColumnId { get; set; }
    public virtual Column? Column { get; set; }
}