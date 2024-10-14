using Microsoft.CodeAnalysis.CSharp.Syntax;
using ServerApp.Data.Models.EditModel;

namespace ServerApp.Data.Models.InspectionModel;

public class ApplicationFormInspectionModel
{
    private readonly ApplicationForm applicationForm;
    
    public ApplicationFormInspectionModel() { }

    public ApplicationFormInspectionModel(ApplicationForm applicationForm)
    {
        this.applicationForm = applicationForm;
    }

    public Guid Id => applicationForm.Id;
    public string? FullName => applicationForm.UserInfo.Name;
    public Guid? TrackId => applicationForm.TrackId;
    public Guid? CategoryId => applicationForm.CategoryId;

    public FieldModel[] Fields => applicationForm.FieldVals
        .Select(e => new FieldModel(e.Field, applicationForm.UserInfoId)).ToArray();
    public TableModel[] Tables => applicationForm.Track.EditBlocks
        .SelectMany(eb => eb.Tables)
        .OrderBy(t => t.Number).Select(t =>
            new TableModel
            {
                Id = t.Id,
                Name = t.Name,
                Columns = t.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                Rows = t.Rows
                    .Where(r => r.CellVals.OrderBy(c => c.Column!.Number).Any(cv => cv.ApplicationId == applicationForm.Id))
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
            }).ToArray();
}