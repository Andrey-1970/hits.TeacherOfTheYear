using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.ReviewModel;

public class MarkBlockModel
{
    public MarkBlockModel()
    {
        
    }

    public MarkBlockModel(MarkBlock markBlock)
    {
        Id = markBlock.Id;
        Name = markBlock.Name;
    }
    
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int SummaryMarksBlock { get; set; } = 0;
}