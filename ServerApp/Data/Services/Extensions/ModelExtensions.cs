using ServerApp.Data.Entities;
using ServerApp.Data.ViewModels;

namespace ServerApp.Data.Services.Extensions;

public static class ModelExtensions
{
    public static ApplicationModel ToModel(this ApplicationForm entity)
    {
        return new ApplicationModel()
        {
            Id = entity.Id,
            TrackId = entity.TrackId,
            Track = entity.Track?.ToModel()
        };
    }

    public static TrackModel ToModel(this Track entity)
    {
        return new TrackModel()
        {
            Id = entity.Id,
            Name = entity.Name,
            EditBlocks = entity.EditBlocks.Select(eb => eb.ToModel()).ToList()
        };
    }

    public static EditBlockModel ToModel(this EditBlock entity)
    {
        return new EditBlockModel()
        {
            Id = entity.Id,
            Number = entity.Number,
            Name = entity.Name,
            Fields = entity.Fields.Select(f => f.ToModel()).ToList(),
            Tables = entity.Tables.Select(t => t.ToModel()).ToList()
        };
    }

    public static FieldModel ToModel(this Field entity)
    {
        return new FieldModel()
        {
            Id = entity.Id,
            Number = entity.Number,
            Name = entity.Name,
            EditBlockId = entity.EditBlockId,
            // Value = ????
        };
    }

    public static TableModel ToModel(this Table entity)
    {
        return new TableModel()
        {
            Id = entity.Id,
            Number = entity.Number,
            Name = entity.Name,
            EditBlockId = entity.EditBlockId,
            Columns = entity.Columns.Select(c => c.ToModel()).ToList(),
            Rows = entity.Rows.Select(r => r.ToModel()).ToList()
        };
    }

    public static ColumnModel ToModel(this Column entity)
    {
        return new ColumnModel()
        {
            Id = entity.Id,
            Number = entity.Number,
            Name = entity.Name,
            TableId = entity.TableId
        };
    }

    public static RowModel ToModel(this Row entity)
    {
        return new RowModel()
        {
            Id = entity.Id,
            TableId = entity.TableId,
            CellVals = entity.CellVals.Select(cv => cv.ToModel()).ToList()
        };
    }

    public static CellValModel ToModel(this CellVal entity)
    {
        return new CellValModel()
        {
            Id = entity.Id,
            RowId = entity.RowId,
            ColumnId = entity.ColumnId,
            Value = entity.Value
        };
    }
    
    public static ApplicationForm ToEntity(this ApplicationModel dto)
    {
        return new ApplicationForm
        {
            Id = dto.Id,
            TrackId = dto.TrackId,
            Track = dto.Track?.ToEntity(),
        };
    }

    public static Track ToEntity(this TrackModel dto)
    {
        return new Track
        {
            Id = dto.Id,
            Name = dto.Name,
            EditBlocks = dto.EditBlocks.Select(eb => eb.ToEntity()).ToList()
        };
    }

    public static EditBlock ToEntity(this EditBlockModel dto)
    {
        return new EditBlock
        {
            Id = dto.Id,
            Number = dto.Number,
            Name = dto.Name,
            Fields = dto.Fields.Select(f => f.ToEntity()).ToList(),
            Tables = dto.Tables.Select(t => t.ToEntity()).ToList()
        };
    }

    public static Field ToEntity(this FieldModel dto)
    {
        return new Field
        {
            Id = dto.Id,
            Number = dto.Number,
            Name = dto.Name,
            EditBlockId = dto.EditBlockId,
            // ????? = dto.Value
        };
    }

    public static Table ToEntity(this TableModel dto)
    {
        return new Table
        {
            Id = dto.Id,
            Number = dto.Number,
            Name = dto.Name,
            EditBlockId = dto.EditBlockId,
            Columns = dto.Columns.Select(c => c.ToEntity()).ToList(),
            Rows = dto.Rows.Select(r => r.ToEntity()).ToList()
        };
    }

    public static Column ToEntity(this ColumnModel dto)
    {
        return new Column
        {
            Id = dto.Id,
            Number = dto.Number,
            Name = dto.Name,
            TableId = dto.TableId
        };
    }

    public static Row ToEntity(this RowModel dto)
    {
        return new Row
        {
            Id = dto.Id,
            TableId = dto.TableId,
            CellVals = dto.CellVals.Select(cv => cv.ToEntity()).ToList()
        };
    }

    public static CellVal ToEntity(this CellValModel dto)
    {
        return new CellVal
        {
            Id = dto.Id,
            RowId = dto.RowId,
            ColumnId = dto.ColumnId,
            Value = dto.Value
        };
    }

}