namespace ServerApp.Data.ViewModels;

public class TableModel
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public string? Name { get; set; }
    public Guid EditBlockId { get; set; }
    public List<ColumnModel> Columns { get; set; }
    public List<RowModel> Rows { get; set; }

}