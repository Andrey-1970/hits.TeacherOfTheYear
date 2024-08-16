namespace ServerApp.Data.ViewModels;

public class TrackModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public List<EditBlockModel> EditBlocks { get; set; }

}