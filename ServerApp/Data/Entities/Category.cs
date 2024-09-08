using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities;

public class Category : BaseEntity
{
    public int Number { get; set; }
    [MaxLength(255)]
    public string? Name { get; set; }
    public virtual List<ApplicationForm> ApplicationForms { get; set; } = [];
}