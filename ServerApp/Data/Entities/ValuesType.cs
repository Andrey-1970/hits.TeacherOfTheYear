namespace ServerApp.Data.Entities;

public class ValuesType
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public virtual Field[] Fields { get; set; } = [];
    public virtual Column[] Columns { get; set; } = [];
}