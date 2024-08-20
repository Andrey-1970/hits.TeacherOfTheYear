using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        [MaxLength(255)] public string? Name { get; set; }
        [MaxLength(255)] public string? Username { get; set; }
        public virtual List<ApplicationForm> Applications { get; set; } = [];
    }
}
