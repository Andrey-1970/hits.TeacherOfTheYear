using ServerApp.Data.Entities;

namespace ServerApp.Data.Models;

public class ColumnModel
{
    public ColumnModel()
    {
        
    }

    public ColumnModel(Column column)
    {
        if (column == null)
            throw new ArgumentNullException(nameof(column));
        Id = column.Id;
        Name = column.Name;
        ValueType = column.ValueType!.Name;
    }

    public Column ToEntity()
    {
        return new Column()
        {
            Id = this.Id,
            Name = this.Name
        };
    }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ValueType { get; set; }
}