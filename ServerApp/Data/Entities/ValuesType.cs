namespace ServerApp.Data.Entities;

public class ValuesType
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public virtual List<Field> Fields { get; set; } = [];
    public virtual List<Column> Columns { get; set; } = [];
}