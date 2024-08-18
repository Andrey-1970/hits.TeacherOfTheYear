using ServerApp.Data.Entities;

namespace ServerApp.Data.Models
{
    public class DemoEditModel
    {
        public DemoEditModel()
        {
            
        }
        public DemoEditModel(ApplicationForm applicationForm, ApplicationDbContext context)
        {
            if (applicationForm == null) throw new ArgumentNullException(nameof(applicationForm));
            ApplicationId = applicationForm.Id;
            SelectedTrackId = applicationForm.TrackId;
            Tracks = context.Tracks.Select(e => new TrackModel(e));
            EditBlocks = applicationForm.Track?.EditBlocks.Select(e => new EditBlockModel(e)) ?? [];
        }

        public ApplicationForm ToEntity()
        {
            if (SelectedTrackId == null) throw new InvalidOperationException("SelectedTrackId cannot be null.");

            return new ApplicationForm
            {
                Id = this.ApplicationId,
                TrackId = (Guid)this.SelectedTrackId,
            };
        }

        public Guid ApplicationId { get; set; }
        public Guid? SelectedTrackId { get; set; }
        public Guid? SelectedEditBlockId { get; set; }
        public IEnumerable<TrackModel> Tracks { get; set; } = [];
        public IEnumerable<EditBlockModel> EditBlocks { get; set; } = [];
        public InputModel[] Inputs { get; set; } = [];
        public TableModel[] Tables { get; set; } = [];
    }
}
