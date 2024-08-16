namespace ServerApp.Data.ViewModels;

public class ApplicationModel
{
    public Guid Id { get; set; }
    public Guid TrackId { get; set; }
    public TrackModel? Track { get; set; }

}