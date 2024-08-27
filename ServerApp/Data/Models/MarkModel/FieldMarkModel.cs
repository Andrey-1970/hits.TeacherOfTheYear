using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.MarkModel;

public class FieldMarkModel
{
    public FieldMarkModel()
    {
        
    }
    
    public FieldMarkModel(Field field, UserInfo user)
    {
        ArgumentNullException.ThrowIfNull(field);
        Id = field.Id;
        ValId = (field.FieldVals.FirstOrDefault(e => e.ApplicationId == user.Applications.FirstOrDefault()?.Id) ?? new FieldVal()).Id;
        Number = field.Number;
        Name = field.Name;
        Value = field.FieldVals.FirstOrDefault(e => e.ApplicationId == user.Applications.FirstOrDefault()?.Id)?.Value;
    }
    
    public Guid Id { get; set; }
    public Guid ValId { get; set; }
    public int? Number { get; set; }
    public string? Name { get; set; }
    public string? EditGroup { get; set; }
    public string? Value { get; set; }
    public MarkModel[] Marks { get; set; } = [];
}