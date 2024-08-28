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
        IsPrefilled = table.IsPrefilled;
        Columns = table.Columns.OrderBy(c => c.Number).Select(c => new ColumnModel(c)).ToList();
        Rows = table.Rows.Select(r => new RowModel(r)).ToList();
    }

    public Table ToEntity()
    {
        return new Table()
        {
            Id = this.Id,
            Name = this.Name,
            Columns = this.Columns.Select(c => c.ToEntity()).ToList(),
            Rows = this.Rows.Select(r => r.ToEntity()).ToList(),
            IsPrefilled = this.IsPrefilled
        };
    }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public bool IsPrefilled { get; set; }
    public List<ColumnModel> Columns { get; set; } = [];
    public List<RowModel> Rows { get; set; } = [];
}