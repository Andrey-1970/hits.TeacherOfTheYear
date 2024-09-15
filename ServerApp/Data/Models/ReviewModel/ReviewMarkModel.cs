using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;

namespace ServerApp.Data.Models.ReviewModel;

public class ReviewMarkModel
{
    public ReviewMarkModel()
    {
        
    }

    public ReviewMarkModel(ApplicationForm applicationForm)
    {
        ApplicationId = applicationForm.Id;
        SelectedTrackId = applicationForm.TrackId;
    }
    
    public Guid ApplicationId { get; set; }
    public Guid? SelectedTrackId { get; set; }
    public Guid SelectedMarkBlockId { get; set; }
    public MarkBlockModel[] MarkBlocks { get; set; } = [];
    public FieldModel[] Fields { get; set; } = [];
    public TableModel[] Tables { get; set; } = [];
    public BlockReviewModel[] ReviewedBlocks { get; set; } = [];
}