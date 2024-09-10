using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Data.Entities;

public class ApplicationForm
{
    public Guid Id { get; set; }
    public Guid ApplicationStatusId { get; set; }
    public virtual ApplicationStatus ApplicationStatus { get; set; } = default!;
    public Guid UserInfoId { get; set; }
    public virtual UserInfo UserInfo { get; set; }
    public Guid TrackId { get; set; }
    public virtual Track Track { get; set; }
    public virtual Guid? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
    public Guid? ReviewerId { get; set; }
    [ForeignKey(nameof(ReviewerId))]
    public virtual UserInfo? Reviewer { get; set; }
    public virtual List<BlockReview> BlockReviews { get; set; } = new();
    public virtual List<MarkVal> MarkVals { get; set; } = new();
    public virtual List<FieldVal> FieldVals { get; set; } = new();
    public virtual List<CellVal> CellVals { get; set; } = new();
    public virtual List<EditBlockStatus> EditBlockStatusList { get; set; } = new();
    public virtual List<Vote> Votes { get; set; } = new();

    public virtual List<ApplicationFormExpert> ApplicationFormExperts { get; set; } = new(); // Связь многие ко многим
}