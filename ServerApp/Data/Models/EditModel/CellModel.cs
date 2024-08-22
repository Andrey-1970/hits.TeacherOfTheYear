using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

public class CellModel
{
    public CellModel()
    {
        
    }

    public CellModel(CellVal cell)
    {
        if (cell == null)
            throw new ArgumentNullException(nameof(cell));
        Id = cell.Id;
        Value = cell.Value;
    }

    public CellVal ToEntity()
    {
        return new CellVal()
        {
            Id = this.Id,
            Value = this.Value
        };
    }
    public Guid Id { get; set; }
    public string? ValueType { get; set; }
    public string?[] SelectValues { get; set; } = [];
    public string? Value { get; set; }
}