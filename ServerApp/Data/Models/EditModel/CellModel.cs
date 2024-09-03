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
        IsPrefilled = cell.IsPrefilled;
        Disable = cell.Disable;
        Value = cell.Value;
        ColumnId = cell.ColumnId;
        IsRequired = cell.Column!.IsRequired;
        ValueType = cell.Column.ValueType!.Name;
        SelectValues = cell.Column.SelectValues.Select(e => e.Value).ToArray();
    }

    public CellVal ToEntity()
    {
        return new CellVal()
        {
            Id = this.Id,
            Value = this.Value,
            ColumnId = this.ColumnId,
            Disable = this.Disable
        };
    }
    public Guid Id { get; set; }
    public bool IsPrefilled { get; set; }
    public bool Disable { get; set; }
    public bool IsRequired { get; set; }
    public string? ValueType { get; set; }
    public string?[] SelectValues { get; set; } = [];
    public string? Value { get; set; }
    public Guid ColumnId { get; set; }
}