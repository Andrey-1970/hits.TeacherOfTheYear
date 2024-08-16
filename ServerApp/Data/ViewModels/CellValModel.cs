namespace ServerApp.Data.ViewModels;

public class CellValModel
{
    public Guid Id { get; set; }
    public Guid RowId { get; set; }
    public Guid ColumnId { get; set; }
    public string? Value { get; set; }

}