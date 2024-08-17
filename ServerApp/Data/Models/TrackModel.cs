using ServerApp.Data.Entities;

namespace ServerApp.Data.Models
{
    public class TrackModel
    {
        public TrackModel()
        {

        }
        public TrackModel(Track track)
        {

        }
        public Track ToEntity(TrackModel model)
        {
            return new();
        }
        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }
    }
}
