namespace ServerApp.Data.Models;

public class RowModel
{
    public Guid Id { get; set; }
    public CellModel[] Cells { get; set; } = [];
}