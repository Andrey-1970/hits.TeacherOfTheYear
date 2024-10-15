using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.ReviewModel;

namespace ServerApp.Data.Models.InspectionModel;

public class ApplicationFormInspectionModel
{
    private readonly ApplicationForm applicationForm;
    private readonly Guid? markBlockId;

    public ApplicationFormInspectionModel()
    {
    }

    public ApplicationFormInspectionModel(ApplicationForm applicationForm, Guid? markBlockId)
    {
        this.applicationForm = applicationForm;
        this.markBlockId = markBlockId != null ? (Guid)markBlockId : applicationForm.Track != null ?  applicationForm.Track.MarkBlocks.FirstOrDefault(e => e.Number == 1).Id : null;
    }

    public Guid Id => applicationForm.Id;
    public string? FullName => applicationForm.UserInfo.Name;
    public Guid? TrackId => applicationForm.TrackId;
    public Guid? CategoryId => applicationForm.CategoryId;

    public Guid SelectedMarkBlockId => (Guid)markBlockId;
    public MarkBlockModel[] MarkBlocks => applicationForm.Track != null ? applicationForm.Track.MarkBlocks.OrderBy(e => e.Number).Select(e => new MarkBlockModel(e)).ToArray() : [];

    public FieldModel[] Fields => applicationForm.Track != null ? applicationForm.Track.MarkBlocks
        .FirstOrDefault(e => e.Id == markBlockId)
        .Fields
        .OrderBy(e => e.Number)
        .Select(e => new FieldModel(e, applicationForm.UserInfoId))
        .ToArray() : [];

    public TableModel[] Tables => applicationForm.Track != null ? applicationForm.Track.MarkBlocks.Where(e => e.Id == markBlockId)
        .SelectMany(eb => eb.Tables)
        .OrderBy(t => t.Number).Select(t =>
            new TableModel
            {
                Id = t.Id,
                Name = t.Name,
                Columns = t.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                Rows = t.Rows
                    .Where(r => r.CellVals.OrderBy(c => c.Column!.Number)
                        .Any(cv => cv.ApplicationId == applicationForm.Id))
                    .OrderBy(r => r.Number)
                    .Select(r => new RowModel
                    {
                        Id = r.Id,
                        Cells = r.CellVals
                            .OrderBy(c => c.Column!.Number)
                            .Where(cv => cv.ApplicationId == applicationForm.Id)
                            .Select(cv => new CellModel
                            {
                                Id = cv.Id,
                                Value = cv.Value,
                                ColumnId = cv.ColumnId
                            }).ToList()
                    }).ToList()
            }).ToArray() : [];
}