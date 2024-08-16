namespace ServerApp.Data.ViewModels;

public class FieldModel
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public string? Name { get; set; }
    public Guid EditBlockId { get; set; }
    public string? Value { get; set; }

}