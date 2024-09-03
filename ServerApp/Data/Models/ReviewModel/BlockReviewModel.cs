using System.ComponentModel.DataAnnotations;
using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.ReviewModel;

public class BlockReviewModel
{
    public BlockReviewModel()
    {
        
    }

    public BlockReviewModel(BlockReview review)
    {
        Id = review.Id;
        Status = review.Status;
        Commentary = review.Commentary;
        MarkBlockId = review.MarkBlockId;
    }
    
    public Guid Id { get; set; }
    public bool Status { get; set; } = false;
    [MaxLength(2048)]
    public string? Commentary { get; set; }
    public Guid MarkBlockId { get; set; }
}