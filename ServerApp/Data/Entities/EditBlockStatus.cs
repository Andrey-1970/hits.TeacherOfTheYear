namespace ServerApp.Data.Entities;

public class EditBlockStatus
{
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public virtual Guid ApplicationId { get; set; }
    public virtual ApplicationForm Application { get; set; } = default!;
    public virtual Guid EditBlockId { get; set; }
    public virtual EditBlock EditBlock { get; set; } = default!;
}