using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities;

public class MarkVal
{
    public Guid Id { get; set; }
    [MaxLength(255)] public int? Value { get; set; }
    public virtual Guid ApplicationId { get; set; }
    public virtual ApplicationForm? Application { get; set; }
    public virtual Guid MarkId { get; set; }
    public virtual Mark? Mark { get; set; }
    public virtual Guid? ExpertId { get; set; }
    public virtual UserInfo? Expert { get; set; }
    public bool IsAuto { get; set; } = true;
}