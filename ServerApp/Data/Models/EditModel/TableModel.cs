using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

public class TableModel
{
    public TableModel()
    {
        
    }

    public TableModel(Table table)
    {
        if (table == null)
            throw new ArgumentNullException(nameof(table));
        Id = table.Id;
        Name = table.Name;
        Columns = table.Columns.Select(c => new ColumnModel(c)).ToArray();
        Rows = table.Rows.Select(r => new RowModel(r)).ToArray();
    }

    public Table ToEntity()
    {
        return new Table()
        {
            Id = this.Id,
            Name = this.Name,
            Columns = this.Columns.Select(c => c.ToEntity()).ToList(),
            Rows = this.Rows.Select(r => r.ToEntity()).ToList()
        };
    }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ColumnModel[] Columns { get; set; } = [];
    public RowModel[] Rows { get; set; } = [];
}