namespace ServerApp.Data.Entities;

public class Vote
{
    public Guid Id { get; set; }
    public DateTime VoteTime { get; set; }
    public virtual Guid VoterId { get; set; }
    public virtual UserInfo Voter { get; set; } = default!;
    public virtual Guid ApplicationFormId { get; set; }
    public virtual ApplicationForm ApplicationForm { get; set; } = default!;
}