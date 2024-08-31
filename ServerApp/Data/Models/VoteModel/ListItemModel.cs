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
    }
    
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string? FullName { get; set; }
    //todo: Проработать модель
}