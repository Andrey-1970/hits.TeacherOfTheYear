using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

public class TrackModel
{
    public TrackModel()
    {
        
    }
    public TrackModel(Track track)
    {
        //ArgumentNullException.ThrowIfNull(track);
        Id = track.Id;
        Number = track.Number;
        Name = track.Name;
    }

    public Track ToEntity()
    {
        if (Number == null) throw new InvalidOperationException("Number cannot be null.");
        
        return new Track
        {
            Id = this.Id,
            Number = (int)this.Number,
            Name = this.Name
        };
    }

    public Guid Id { get; set; }
    public int? Number { get; set; }
    public string? Name { get; set; }
}