using ServerApp.Components.Pages;

namespace ServerApp.Data.Entities;

public class Photo
{
    public Guid Id { get; set; }
    public virtual Guid ApplicationFormId { get; set; }
    public virtual ApplicationForm ApplicationForm { get; set; } = default!;

    public string Base64Data { get; set; } = default!;
    public int? X { get; set; }
    public int? Y { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
}