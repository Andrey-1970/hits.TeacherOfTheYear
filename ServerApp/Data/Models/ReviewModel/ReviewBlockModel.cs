using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.ReviewModel;

public class ReviewBlockModel
{
    public ReviewBlockModel()
    {
        
    }

    public ReviewBlockModel(BlockReviewStatus review)
    {
        Id = review.Id;
        ReviewStatus = review.ReviewStatus;
        Commentary = review.Commentary;
        MarkBlockId = review.MarkBlockId;
    }
    
    public Guid Id { get; set; }
    public bool ReviewStatus { get; set; } = false;
    public string? Commentary { get; set; }
    public Guid MarkBlockId { get; set; }
}