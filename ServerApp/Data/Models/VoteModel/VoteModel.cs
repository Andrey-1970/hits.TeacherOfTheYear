using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.VoteModel;

public class VoteModel
{
    public VoteModel()
    {
        
    }

    public VoteModel(ApplicationForm applicationForm, Guid userId)
    {
        Id = applicationForm.Id;
        TotalVotes = applicationForm.Votes.Count;
        IsVoteOfThisApplication = applicationForm.Votes.Any(e => e.ApplicationFormId == applicationForm.Id && e.VoterId == userId);
    }
    
    public Guid Id { get; set; } //fullname WorkPlace Идентификаторы КонкурснаяWork 
    public int TotalVotes { get; set; }
    public bool IsVoteOfThisApplication { get; set; }
    //todo: Проработать поля
}