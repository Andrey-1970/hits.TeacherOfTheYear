using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;

namespace ServerApp.Data.Models.VoteModel;

public class ApplicationFormVoteModel
{
    readonly ApplicationForm applicationForm;
    readonly Guid userId;

    public ApplicationFormVoteModel() { }

    public ApplicationFormVoteModel(ApplicationForm applicationForm, Guid userId)
    {
        this.applicationForm = applicationForm;
        this.userId = userId;
    }

    public Guid Id => applicationForm.Id;
    public string? FullName => applicationForm.UserInfo.Name;
    public int? TotalVotes => applicationForm.Votes.Count;

    public bool IsVoteOfThisApplication => applicationForm.Votes.Any(x => x.VoterId == userId);
    public FieldModel[] Fields { get; set; } = [];
    public TableModel[] Tables { get; set; } = [];
}