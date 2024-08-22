using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

public class EditBlockStatusModel
{
    public EditBlockStatusModel()
    {
        
    }

    public EditBlockStatusModel(EditBlockStatus editBlockStatus)
    {
        Id = editBlockStatus.Id;
        Status = editBlockStatus.Status;
        EditBlockId = editBlockStatus.EditBlockId;
    }
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public Guid EditBlockId { get; set; }
}