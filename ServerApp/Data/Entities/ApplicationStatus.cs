using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities;

public class ApplicationStatus
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    [MaxLength(128)]
    public string Status { get; set; } = default!;
    public virtual List<ApplicationForm> ApplicationForms { get; set; } = [];
}