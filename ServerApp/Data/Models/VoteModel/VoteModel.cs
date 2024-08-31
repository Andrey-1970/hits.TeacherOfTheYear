using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.VoteModel;

public class VoteModel
{
    public VoteModel()
    {
        
    }

    public VoteModel(ApplicationForm applicationForm)
    {
        Id = applicationForm.Id;
    }
    
    public Guid Id { get; set; }
    //todo: Проработать поля
}