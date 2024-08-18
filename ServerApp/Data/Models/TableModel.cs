namespace ServerApp.Data.Models;

public class TableModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ColumnModel[] Columns { get; set; } = [];
    public RowModel[] Rows { get; set; } = [];
}