using System.ComponentModel.DataAnnotations;
using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.VoteModel;

public class ApplicationCardModel
{
    public ApplicationCardModel()
    {
        
    }

    public ApplicationCardModel(ApplicationForm applicationForm)
    {
        Id = applicationForm.Id;
        FullName = applicationForm.FieldVals.FirstOrDefault(e => e.Field!.Name == "ФИО")!.Value;
        WorkPlace = applicationForm.FieldVals.FirstOrDefault(e => e.Field!.Name == "Место работы")!.Value;
        Faculty = applicationForm.FieldVals.FirstOrDefault(e => e.Field!.Name == "Институт, факультет, кафедра, лаборатория")!.Value;
        CropPhoto = applicationForm.CropPhoto!.Base64Data;
    }
    
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string? FullName { get; set; }
    [MaxLength(255)]
    public string? WorkPlace { get; set; }
    public string? Faculty { get; set; }
    public string CropPhoto { get; set; }
    public bool IsVoted { get; set; } = false;
}