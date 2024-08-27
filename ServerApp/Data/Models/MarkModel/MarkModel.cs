namespace ServerApp.Data.Models.MarkModel;

public class MarkModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public bool IsAuto { get; set; }
    public int? Value { get; set; }
    public int? MaxValue { get; set; }
    //todo: итог блока
}