using System.Runtime.InteropServices.JavaScript;
using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

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
        Cells = row.CellVals.OrderBy(e => e.Column!.Number).Select(c => new CellModel(c)).ToList();
        Number = row.Number;
    }

    public Row ToEntity()
    {
        return new Row()
        {
            Id = this.Id,
            CellVals = this.Cells.Select(c => c.ToEntity()).ToList(),
            Number = this.Number
        };
    }
        
    public Guid Id { get; set; }
    public List<CellModel> Cells { get; set; } = [];
    public int? Number { get; set; }
}