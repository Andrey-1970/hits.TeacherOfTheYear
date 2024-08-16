namespace ServerApp.Data.ViewModels;

public class ColumnModel
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public string? Name { get; set; }
    public Guid TableId { get; set; }

}