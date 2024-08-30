using ServerApp.Data.Models.EditModel;

namespace ServerApp.Data.Models.MarkModel;

public class TableMarkModel
{
    public TableMarkModel()
    {
        
    }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public List<ColumnModel> Columns { get; set; } = [];
    public List<RowModel> Rows { get; set; } = [];
    public MarkModel[] Marks { get; set; } = [];
}