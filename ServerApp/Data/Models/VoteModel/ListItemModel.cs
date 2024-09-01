using System.ComponentModel.DataAnnotations;
using ServerApp.Data.Entities;

namespace ServerApp.Data.Models.VoteModel;

public class ListItemModel
{
    public ListItemModel()
    {
        
    }

    public ListItemModel(ApplicationForm applicationForm)
    {
        Id = applicationForm.Id;
        FullName = applicationForm.FieldVals.FirstOrDefault(e => e.Field!.Name == "ФИО")!.Value;
        WorkPlace = applicationForm.FieldVals.FirstOrDefault(e => e.Field!.Name == "Место работы/учебы")!.Value;
        AcademicDegree = applicationForm.FieldVals.FirstOrDefault(e => e.Field!.Name == "Ученая степень")!.Value;
    }
    
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string? FullName { get; set; }
    [MaxLength(255)]
    public string? WorkPlace { get; set; }
    public string? AcademicDegree { get; set; }
    //todo: Проработать модель
}