using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ServerApp.Data.Entities
{
    public class FeedBack
    {
        public FeedBack() { }
        public FeedBack(FeedBack feedback) 
        {
            ArgumentNullException.ThrowIfNull(feedback);
            Id = feedback.Id;
            Name = feedback.Name;
            Email = feedback.Email;
            Message = feedback.Message;
            Checked = feedback.Checked;

        }
        public FeedBack ToEntity()
        {
            return new FeedBack
            {
                Id = this.Id,
                Name = this.Name,
                Email = this.Email,
                Message = this.Message,
                Checked = this.Checked,
            };
        }
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public bool Checked { get; set; }
    }
}
/*using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.EditModel;

public class TrackModel
{
    public TrackModel()
    {
        
    }
    public TrackModel(Track track)
    {
        ArgumentNullException.ThrowIfNull(track);
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
}*/