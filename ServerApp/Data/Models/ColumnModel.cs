using ServerApp.Data.Entities;

namespace ServerApp.Data.Models;

public class ColumnModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ValueType { get; set; }
}