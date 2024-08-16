using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Models
{
    public class InputModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string? Value { get; set; }
    }
}
