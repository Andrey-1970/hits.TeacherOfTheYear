using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel
{
    public class EditModel
    {
        public EditModel()
        {
            
        }
        public EditModel(ApplicationForm applicationForm)
        {
            ArgumentNullException.ThrowIfNull(applicationForm);
            ApplicationId = applicationForm.Id;
            SelectedTrackId = applicationForm.TrackId;
            SelectedCategoryId = applicationForm.CategoryId;
        }

        public ApplicationForm ToEntity()
        {
            if (SelectedTrackId == null) throw new InvalidOperationException("SelectedTrackId cannot be null.");
            if (SelectedCategoryId == null) throw new InvalidOperationException("SelectedCategoryId cannot be null.");

            return new ApplicationForm
            {
                Id = this.ApplicationId,
                TrackId = (Guid)this.SelectedTrackId,
                CategoryId = (Guid)this.SelectedCategoryId
            };
        }

        public Guid ApplicationId { get; set; }
        public Guid? SelectedTrackId { get; set; }
        public Guid? SelectedCategoryId { get; set; }
        public Guid? SelectedEditBlockId { get; set; }
        public IEnumerable<TrackModel> Tracks { get; set; } = [];
        public IEnumerable<EditBlockModel> EditBlocks { get; set; } = [];
        public FieldModel[] Fields { get; set; } = [];
        public TableModel[] Tables { get; set; } = [];
    }
}
