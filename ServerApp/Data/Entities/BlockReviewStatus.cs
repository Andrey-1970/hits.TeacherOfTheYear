using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities;

public class BlockReviewStatus
{
    public Guid Id { get; set; }
    public bool ReviewStatus { get; set; } = false;
    [MaxLength(500)]
    public string? Commentary { get; set; }
    public virtual Guid ApplicationId { get; set; }
    public virtual ApplicationForm Application { get; set; } = default!;
    public virtual Guid MarkBlockId { get; set; }
    public virtual MarkBlock MarkBlock { get; set; } = default!;
    public virtual Guid ReviewerId { get; set; }
    public virtual UserInfo Reviewer { get; set; } = default!;
}