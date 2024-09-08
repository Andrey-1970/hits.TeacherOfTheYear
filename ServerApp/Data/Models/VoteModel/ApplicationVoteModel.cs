using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;

namespace ServerApp.Data.Models.VoteModel;

public class ApplicationVoteModel
{
    public ApplicationVoteModel()
    {
        
    }

    public ApplicationVoteModel(ApplicationForm applicationForm, Guid userId)
    {
        Id = applicationForm.Id;
        FullName = applicationForm.UserInfo.Name!;
        IsVoteOfThisApplication = applicationForm.Votes.Any(e => e.ApplicationFormId == applicationForm.Id && e.VoterId == userId);
        TotalVotes = applicationForm.Votes.Count;
    }
    
    public Guid Id { get; set; } //fullname WorkPlace Идентификаторы КонкурснаяWork 
    public string? FullName { get; set; }
    public bool IsVoteOfThisApplication { get; set; } = false;
    public int? TotalVotes { get; set; }
    public FieldModel[] Fields { get; set; } = [];
    public TableModel[] Tables { get; set; } = [];
}