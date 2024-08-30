using ServerApp.Data.Entities;
using ServerApp.Data.Models.ReviewModel;

namespace ServerApp.Data.Models.MarkModel;

public class AssessmentModel
{
    public AssessmentModel()
    {
        
    }

    public AssessmentModel(ApplicationForm applicationForm)
    {
        ArgumentNullException.ThrowIfNull(applicationForm);
        ApplicationId = applicationForm.Id;
        SelectedTrackId = applicationForm.TrackId;
    }
    
    public Guid ApplicationId { get; set; }
    public Guid SelectedTrackId { get; set; }
    public Guid SelectedMarkBlockId { get; set; }
    public MarkBlockModel[] MarkBlocks { get; set; } = [];
    public FieldMarkModel[] Fields { get; set; } = [];
    public TableMarkModel[] Tables { get; set; } = [];
    public MarkModel[] Marks { get; set; } = [];
}