using ServerApp.Data.Entities;
using ServerApp.Data.Models;

namespace ServerApp.Data.Services.Extensions;

public static class ModelExtensions
{
    public static DemoEditModel ToModel(this ApplicationForm entity, ApplicationDbContext context)
    {
        var tracks = context.Tracks.ToList();
        return new DemoEditModel()
        {
            ApplicationId = entity.Id,
            SelectedTrackId = entity.TrackId,
            Tracks = tracks.Select(e => e.ToModel()),
            EditBlocks = entity.Track?.EditBlocks.Select(e => e.ToModel()) ?? []
        };
    }

    public static TrackModel ToModel(this Track entity)
    {
        return new TrackModel()
        {
            Id = entity.Id,
            Name = entity.Name
        };
    }

    public static EditBlockModel ToModel(this EditBlock entity)
    {
        return new EditBlockModel()
        {
            Id = entity.Id,
            Name = entity.Name
        };
    }

    public static InputModel ToModel(this Field entity, Guid appId)
    {

        return new InputModel()
        {
            Id = entity.Id,
            Name = entity.Name,
            Value = entity.FieldVals.FirstOrDefault(e => e.ApplicationId == appId)?.Value
        };
    }
}