namespace ServerApp.Data.ViewModels;

public class EditBlockModel
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public string? Name { get; set; }
    public List<FieldModel> Fields { get; set; }
    public List<TableModel> Tables { get; set; }

}