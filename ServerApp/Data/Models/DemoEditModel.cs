namespace ServerApp.Data.Models
{
    public class DemoEditModel
    {
        public int? SelectedTrackId { get; set; }
        public int? SelectedEditBlockId { get; set; }
        public IEnumerable<TrackModel> Tracks { get; set; } = [];
        public IEnumerable<EditBlockModel> EditBlocks { get; set; } = [];
        public IEnumerable<InputModel> Inputs { get; set; } = [];
    }
}
