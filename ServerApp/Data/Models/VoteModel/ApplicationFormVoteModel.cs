using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;

namespace ServerApp.Data.Models.VoteModel;

public class ApplicationFormVoteModel
{
    readonly ApplicationForm applicationForm;
    readonly Guid? userId;

    public ApplicationFormVoteModel() { }

    public ApplicationFormVoteModel(ApplicationForm applicationForm, Guid? userId)
    {
        this.applicationForm = applicationForm;
        this.userId = userId;
    }

    public Guid Id => applicationForm.Id;
    public string? FullName => applicationForm.UserInfo.Name;
    public int? TotalVotes => applicationForm.Votes.Count;
    public Guid? TrackId => applicationForm.TrackId;
    public Guid CategoryId => (Guid)applicationForm.CategoryId!;

    public bool IsVoteOfThisApplication => userId != null ? applicationForm.Votes.Any(x => x.VoterId == userId) : false;

    public FieldModel[] Fields => applicationForm.FieldVals
        .Where(e => e.Field!.IsDisplayedOnVotingPage)
        .OrderBy(e => e.Field.Number)
        .Select(e => new FieldModel(e.Field, applicationForm.UserInfoId))
        .ToArray();
    public TableModel[] Tables => applicationForm.Track.EditBlocks
        .SelectMany(eb => eb.Tables)
    .Where(t => t.IsDisplayedOnVotingPage).OrderBy(t => t.Number).Select(t =>
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