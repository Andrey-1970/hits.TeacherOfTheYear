using ServerApp.Data.Entities;

namespace ServerApp.Data.Models;

public class RowModel
{
    public RowModel()
    {
        
    }

    public RowModel(Row row)
    {
        if (row == null)
            throw new ArgumentNullException(nameof(row));
        Id = row.Id;
        Cells = row.CellVals.Select(c => new CellModel(c)).ToArray();
    }

    public Row ToEntity()
    {
        return new Row()
        {
            Id = this.Id,
            CellVals = this.Cells.Select(c => c.ToEntity()).ToList()
        };
    }
        
    public Guid Id { get; set; }
    public CellModel[] Cells { get; set; } = [];
}