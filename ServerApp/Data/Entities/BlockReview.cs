using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities;

public class BlockReview
{
    public Guid Id { get; set; }
    public bool Status { get; set; } = false;
    [MaxLength(2048)]
    public string? Commentary { get; set; }
    public virtual Guid MarkBlockId { get; set; }
    public virtual MarkBlock MarkBlock { get; set; } = default!;
    public virtual Guid ApplicationId { get; set; }
    public virtual ApplicationForm Application { get; set; } = default!;
}