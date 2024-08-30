using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.MarkModel;

public class MarkModel
{
    public MarkVal ToEntity()
    {
        return new MarkVal()
        {
            Id = this.ValId,
            MarkId = this.Id,
            Value = this.Value
        };
    }
    
    public Guid Id { get; set; }
    public Guid ValId { get; set; }
    public string? Name { get; set; }
    public bool IsAuto { get; set; }
    public int? Value { get; set; }
    public int? MaxValue { get; set; }
    //todo: итог блока
}