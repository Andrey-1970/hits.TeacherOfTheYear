namespace ServerApp.Data.ViewModels;

public class RowModel
{
    public Guid Id { get; set; }
    public Guid TableId { get; set; }
    public List<CellValModel> CellVals { get; set; }
}